using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
namespace Simulator
{
    
    class Sort
    {
        Robot r;
     
        public Sort(Robot r){
            this.r=r;
           
        }

        // Sorting algorithms-- Self Explanatory since the structure is the same as the actual algorithm
        
        public void BubbleSort(Func<Robot.IPointable, Robot.IPointable, bool> sortOrder) //Sort order is passed as a func
        {
            int size = r.Elements.Count;
            Robot._Pointer ppass = r.createPointer("Size-Pass", r.Elements[size-1]); //This creates pointers to be animated
            for (int pass = 1; pass < size; pass++)
            {
                ppass.setIndex(r.Elements[size-pass]);
                Robot._Pointer pi = r.createPointer("I", r.Elements[0]);
                for (int i = 0; i < size - pass; i++)
                {
                    pi.setIndex(r.Elements[i]);
                    if (sortOrder.Invoke(r.Elements[i], r.Elements[i + 1]))
                    {
                        r.Switch(r.Elements[i].value, r.Elements[i + 1].value);
                    }
                }
                pi.Remove(); //Remove pointer when sorting animation is done
            }
            ppass.Remove();
            MessageBox.Show("Sorted!","BubbleSort",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
        public void InsertionSort(Func<Robot.IPointable, Robot.IPointable, bool> sortOrder)
        {
            int size = r.Elements.Count;
            Robot._Pointer key = r.createTemp("Key", "");
            Robot._Pointer pi = r.createPointer("I", r.Elements[0]);
            for (int i = 1; i < size; i++)
            {
                pi.setIndex(r.Elements[i]);
                r.Copy(r.Elements[i].value, key.getIndex().value);
                int j = i - 1;
                Robot._Pointer pj = r.createPointer("J", r.Elements[j],5,1);

                while (j >= 0)
                {
                    pj.setIndex(r.Elements[j]);
                    if (sortOrder.Invoke(r.Elements[j], key.getIndex()))
                    {
                        r.Copy(r.Elements[j].value, r.Elements[j + 1].value);
                        j -= 1;


                    }
                    else break;


                }
                r.Copy(key.getIndex().value, r.Elements[j + 1].value);
                pj.Remove();
            }
            MessageBox.Show("Sorted!", "InsertionSort", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public void SelectionSort(Func<Robot.IPointable, Robot.IPointable, bool> sortOrder)
        {
            int size = r.Elements.Count;
            Robot._Pointer pj = r.createPointer("J", r.Elements[0]);
            for (int j = 0; j < size; j++)
            {
                pj.setIndex(r.Elements[j]);
                Robot._Pointer pmin = r.createPointer("Min", r.Elements[j],5,1);
                Robot._Pointer pi = r.createPointer("I", r.Elements[(j + 1 < size) ? j + 1 : j]);
                for (int i = j + 1; i < size; i++)
                {
                    pi.setIndex(r.Elements[i]);
                  
                    if (sortOrder.Invoke(pmin.getIndex(), r.Elements[i]))
                    {
                        pmin.setIndex(r.Elements[i]);
                    }
                   
                 
                }
               

                r.Switch(r.Elements[j].value, pmin.getIndex().value);
                pi.Remove();
                pmin.Remove();
            }
            pj.Remove();
            MessageBox.Show("Sorted!", "SelectionSort", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void QuickSort(Func<Robot.IPointable, Robot.IPointable, bool> sortOrder, List<Robot.Element> A, int p, int _r)
        {
           

            if (p < _r)
            {
             
               
                int q = partition(sortOrder, A, p, _r);            
                QuickSort(sortOrder, A, p, q);              
                QuickSort(sortOrder, A, q + 1, _r);

            }
            else
            {
                return;
            }
        }
        private int partition(Func<Robot.IPointable, Robot.IPointable, bool> sortOrder, List<Robot.Element> A, int p, int _r)
        {

            Robot._Pointer pp = r.createPointer("P", A[p],5,1);
            Robot._Pointer pr = r.createPointer("R", A[_r],5,1);

            Robot._Pointer pi = r.createPointer("I", A[p]);
            Robot._Pointer px = r.createTemp("X","");
            r.Copy(A[p].value, px.getIndex().value);
          
            Robot._Pointer pj = r.createPointer("J", A[_r]);
                       
            int i=p-1;
            int j=_r+1;

            while (true)
            {
               
                
                
                do{
                    i++;
                    if (i< A.Count)
                    pi.setIndex(A[i]);
                }while(i<_r && sortOrder(px.getIndex(), A[i]));
                 do{
                    j--;
                    if (j>0)
                    pj.setIndex(A[j]);
                }while(j>p && sortOrder(A[j],px.getIndex()));

                              
               
                if (i < j)
                {
                    r.Switch(A[i].value, A[j].value);
                    
                }
                else
                {
                   
                    pi.Remove();
                    pj.Remove();
                    r.removeTemp((Robot.Temp)px.getIndex());
                    px.Remove();
                    pp.Remove();
                    pr.Remove();
                    return j;
                }
            }

        }
    }
}
