using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Drawing;
using System.Threading;
namespace Simulator
{
    class Robot{
       
        public List<Element> Elements; //List of Elements to Sort
        public List<Temp> Temps; //List of Temporary Variables that are created during the sort
        public List<_Pointer> Pointers; //List of Pointers
        Panel container;
        public  int delay = 500;
        public  bool pauseMarker = false; //PauseMarker pauses the animation at important points during 'Steping'
       
        private String[] values;
        public Robot(Panel container, String[] values)
        {
            int[] ints;
            try
            {
                ints = Array.ConvertAll(values, int.Parse);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please input Integers seperated by Commas","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
          Temps= new List<Temp>();
          Elements = new List<Element>();
          Pointers = new List<_Pointer>();
          this.container = container;
          this.values = values;
         int i=0;
       
         double max =ints.Max();
            double factor= 100/max;
            foreach (var value in values)
            {
                Element e=new Element(this,i.ToString(),value);
                Elements.Add(e);
                int val=int.Parse(e.value.Text);
                e.value.BackColor = Color.FromArgb(150+(int)(factor * val), 150+(int)(factor * val), 0);
               
               i++;
            }
           
       
        }
        public void Refresh() //Refresh the sorting panel
        {
            foreach (_Pointer p in Pointers)
            {
                container.Controls.Remove(p.name);
                container.Controls.Remove(p.arrow);
            }
            foreach (Temp t in Temps)
            {
                container.Controls.Remove(t.key);
                container.Controls.Remove(t.value);
            }
            Pointers = new List<_Pointer>();
            Temps = new List<Temp>(); ;
            container.Refresh();
        }
      //Helper Methods to position elements
        private void positionInside(Panel pnl, Label l,int elementCount)
        {
            int gap = 20;
            int length = elementCount * l.PreferredSize.Width + gap * (elementCount - 1);
            int offset= pnl.Size.Width/2-length/2;
            int x = (((pnl.Location.X + offset / 2) < 0) ? 0 : (pnl.Location.X + offset / 2) )+ 10;
            int y = pnl.Height/3 ;
            Point p = new Point(x, y);
            l.Location = p;
        }
        private void positionOnTop(Label l1, Label l2,int offset=1)
        {
            int gap = 10;
            int x = l1.Location.X;
            int y = l1.Location.Y - l2.PreferredHeight-offset*gap;
            Point p = new Point(x, y);
            l2.Location = p;
        }
        private void positionNextTo(Label l1,Label l2, int offset =1)
        {
            int gap=50;
            int x = l1.Location.X + offset*gap;
            int y = l1.Location.Y ;
            Point p = new Point(x, y);
            l2.Location = p;
        }
        //IPointable is anything that a pointer can be pointed to  i.e: Elements , Temp variables

        public interface IPointable
        {
            Robot r { get; set; }
            Label key { get; set; }
            Label value { get; set; }
        }
        public class Element: IPointable
        {
            public Robot r {  get;  set; }
            public Label key {  get;  set; }
            public Label value {  get;  set; }

            public Element(Robot r,string strkey,object objvalue)
            {

                this.r = r;

                value = new Label();
                value.Font = new Font("Arial", 12, FontStyle.Bold);
                value.AutoSize = true;
                value.Text = objvalue.ToString();
                if (r.Elements.Count == 0)
                    r.positionInside(r.container, value,r.values.Length);
                else
                    r.positionNextTo(r.Elements[r.Elements.Count - 1].value, value);

                key = new Label();
                key.AutoSize = true;
                key.Text = strkey;
                r.positionOnTop(value, key);
                
               
                    r.container.Controls.Add(key);
                    r.container.Controls.Add(value);
              

              

            


            }
           
        }
        public class _Pointer
        {
            Robot r;
            IPointable p;
            public Label name;
            public Label arrow;
            string strname;
            int arrowOffset;
            int nameOffset;
            public _Pointer(Robot r, string strname, IPointable p,int arrowOffset=1,int nameOffset=1)
            {
                
                this.r = r;
                this.p = p;
                this.strname = strname;
                this.arrowOffset = arrowOffset;
                this.nameOffset = nameOffset;

                arrow = new Label();
                arrow.AutoSize = true;
                arrow.Text = "è"; //Arrow character
                arrow.Font = new Font("Wingdings", 10,FontStyle.Bold);
                r.positionOnTop(p.key, arrow,arrowOffset);

                name = new Label();
                name.AutoSize = true;
                name.Text = strname;
                name.Font = new Font("Times New Roman", 10, FontStyle.Bold);
                r.positionOnTop(arrow, name,nameOffset);
                r.container.Invoke(new Action(delegate() //Invoke is used to access the UI thread from the sort thread
                {
                    r.container.Controls.Add(arrow);
                    r.container.Controls.Add(name);
                }));
                
            }
            public void setIndex(IPointable p)
            {
                
                this.p = p;
                r.container.Invoke(new Action(delegate()
                {
                r.positionOnTop(p.key, arrow,arrowOffset);
                r.positionOnTop(arrow, name,nameOffset);
                }));
                r.suspend(r.delay);
            }
            public IPointable getIndex()
            {
                return p;
            }
            public void Remove(){
                 r.container.Invoke(new Action(delegate()
                {
                r.container.Controls.Remove(arrow);
                r.container.Controls.Remove(name);
                }));
                 r.Pointers.Remove(this);

            }
        }
      
        public _Pointer createTemp(string strkey, object objvalue)
        {
            Temp t = new Temp(this, null, objvalue);
            Temps.Add(t);
            _Pointer p = new _Pointer(this, strkey, t);
            Pointers.Add(p);
            return p;
        }
        public void removeTemp(Temp t)
        {
              container.Invoke(new Action(delegate()
                {
            container.Controls.Remove(t.value);
            container.Controls.Remove(t.key);
                }));
            Temps.Remove(t);
           
        }
        public List<Temp> createTempArray(int count)
        {
            List<Temp> temp = new List<Temp>();

            for(int i=0;i<count;i++){
                Temp t = new Temp(this,i.ToString(),"temp");
                temp.Add(t);
                }
            return temp;
        }
        public _Pointer createPointer(string strkey, IPointable p, int arrowOffset = 1, int nameOffset = 1)
        {
            _Pointer po = new _Pointer(this, strkey, p, arrowOffset, nameOffset);
            Pointers.Add(po);
            return po;

        }

        public class Temp:IPointable
        {

            public Robot r {  get;  set; }
            public Label key {  get;  set; }
            public Label value {  get;  set; }

            public Temp(Robot r,string strkey,object objvalue)
            {
                this.r = r;
               

                key = new Label();
               
                key.AutoSize = true;
                key.Text = strkey;

                value = new Label();
                value.Font = new Font("Arial", 12, FontStyle.Bold);
                value.AutoSize = true;
                value.Text = objvalue.ToString();

                if (r.Temps.Count == 0)
                {
                    Label seperator = new Label();
                    seperator.AutoSize = true;
                    seperator.Text = "|";
                    seperator.Font = new Font("Arial", 12, FontStyle.Bold);
                    r.positionNextTo(r.Elements[r.Elements.Count - 1].value, seperator);
                   

                    r.positionNextTo(seperator, value);
                   

                    r.positionOnTop(value, key);
                    
                    r.container.Invoke(new Action(delegate()
                    {
                        r.container.Controls.Add(seperator);
                          r.container.Controls.Add(value);
                          r.container.Controls.Add(key);
                      }));
                }
                else
                {
                    r.positionNextTo(r.Temps[r.Temps.Count-1].value, value);
                   

                    r.positionOnTop(value, key);
                    

                    r.container.Invoke(new Action(delegate()
                    {
                        r.container.Controls.Add(value);
                        r.container.Controls.Add(key);
                    }));

                }                

            }
            public void remove()
            {
                  r.container.Invoke(new Action(delegate()
                    {
                r.container.Controls.Remove(key);
                r.container.Controls.Remove(value);
                    }));
            }

          
            

        }
       //Compare two elements
        public int Compare(Label index1, Label index2)
        {

            int val1=0, val2=0;
         
           
                
           
            Graphics g = container.CreateGraphics();
            var p = new Pen(Color.Black, 3);

            int x1 =index1.Location.X+index1.Size.Width/2;
            int y1 = index1.Location.Y;
            int x2 = index2.Location.X + index2.Size.Width / 2;
            int y2 = index2.Location.Y;

           

       

            var point1 = new Point(x1, y1+20);
            var point3 = new Point(x1, y1 + 60);
            var point2 = new Point(x2, y2+20);
         
            var point4 = new Point(x2, y2+60);
            g.DrawLine(p, point1, point3);
            g.DrawLine(p, point2, point4);

            val1 = int.Parse(index1.Text);
            val2 = int.Parse(index2.Text);
            String s= ((val1>val2)?val1+" is Larger":((val1<val2)?val1+" is Smaller":"Values are equal"));
            g.DrawLine(p, point3, point4);
            int x=((x1<x2)?x1:x2)+Math.Abs(x1-x2)/4;
            g.DrawString("Compare; " + s, new Font("Arial", 10, FontStyle.Bold), new SolidBrush(Color.Black), new Point(x, y1 + 70));

            suspend(delay);

           
       

           g.Clear(Color.Azure);
        
             
           
            return val1.CompareTo(val2);
        }
        // Suspends the animation during 'pausing' and 'steping'
        private  void suspend(int _delay)
        {
            if (pauseMarker == true)
                Thread.CurrentThread.Suspend();
            else
                Thread.Sleep(_delay);

        }
        //Switches two Elements
        public void Switch(Label index1, Label index2)
        {
          
             
            Graphics g = container.CreateGraphics();
            var p = new Pen(Color.DarkKhaki, 3);

            int x1 = index1.Location.X + index1.Size.Width / 2;
            int y1 = index1.Location.Y;
            int x2 = index2.Location.X + index2.Size.Width / 2;
            int y2 = index2.Location.Y;



            //gets points 50px above index 1,2

            var point1 = new Point(x1, y1 + 20);
            var point3 = new Point(x1, y1 + 60);
            var point2 = new Point(x2, y2 + 20);

            var point4 = new Point(x2, y2 + 60);
            g.DrawLine(p, point1, point3);
            g.DrawLine(p, point2, point4);

            int val1 = int.Parse(index1.Text);
            int val2 = int.Parse(index2.Text);
            g.DrawLine(p, point3, point4);
            int x = ((x1 < x2) ? x1 : x2) + Math.Abs(x1 - x2) / 2;
            g.DrawString("Switch", new Font("Arial", 10,FontStyle.Bold), new SolidBrush(Color.Black), new Point(x,y1+70));

            suspend(delay);

            

            string temp = index1.Text;
            Color ctemp = index1.BackColor;
            
            container.Invoke(new Action(delegate()
            {

                index1.Text = index2.Text;
                index2.Text = temp;


                index1.BackColor = index2.BackColor;
                index2.BackColor = ctemp;

            container.Refresh();
              }));

            suspend(delay);
        }
        //Copies one element to another
        public void Copy(Label copyFrom, Label copyTo)
        {
               
            Graphics g = container.CreateGraphics();
            var p = new Pen(Color.DarkKhaki, 3);

            int x1 = copyFrom.Location.X + copyFrom.Size.Width / 2;
            int y1 = copyFrom.Location.Y;
            int x2 = copyTo.Location.X + copyTo.Size.Width / 2;
            int y2 = copyTo.Location.Y;



          

            var point1 = new Point(x1, y1 + 25);
            var point3 = new Point(x1, y1 + 60);
            var point2 = new Point(x2, y2 + 25);
            var point4 = new Point(x2, y2 + 60);
            var point5 = new Point(x2-11, y2 + 20);

            g.DrawLine(p, point1, point3);
            g.DrawLine(p, point2, point4);

            int val1 = int.Parse(copyFrom.Text);
         
            g.DrawLine(p, point3, point4);
            int x = ((x1 < x2) ? x1 : x2) + Math.Abs(x1 - x2) / 2;
            g.DrawString("Copy", new Font("Arial", 10, FontStyle.Bold), new SolidBrush(Color.Black), new Point(x, y1+ 70));
            g.DrawString("é", new Font("Wingdings", 13, FontStyle.Bold), new SolidBrush(Color.DarkKhaki), point5);

            suspend(delay);

           


        
            container.Invoke(new Action(delegate()
            {
                copyTo.Text = copyFrom.Text;
                copyTo.BackColor = copyFrom.BackColor;
            container.Refresh();
               }));
            suspend(delay);
        }
       
    }
}
