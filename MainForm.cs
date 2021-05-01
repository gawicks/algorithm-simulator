using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Threading;
namespace Simulator
{
    public partial class MainFrom : Form
    {
        Robot r;
        Func<Robot.IPointable, Robot.IPointable, bool> ascending; //Function pointer for ascending sorting
        Func<Robot.IPointable, Robot.IPointable, bool> descending;
        Func<Robot.IPointable, Robot.IPointable, bool> sortOrder; //currently selected sort order
        Sort s;
        Thread t; 
      
           
        public MainFrom()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

        }
       
       

        private void createRobot()
        { //Creates a Robot which runs the sort animation -- REFER TO THE ROBOT CLASS
            String[] o = txtValues.Text.Split(','); //gets values from user


            r = new Simulator.Robot(RobotContainer, o);
            ascending = (Pointable1, Pointable2) => (r.Compare(Pointable1.value, Pointable2.value) > 0); //Setting the ascending function to the function pointer
            descending = (Pointable1, Pointable2) => (r.Compare(Pointable1.value, Pointable2.value) < 0);
            r.delay = tbSpeed.Maximum-tbSpeed.Value;
            r.pauseMarker = false;
            sortOrder = ascending;
            s = new Sort(r);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            generateRandomValues();
            createRobot();
        }

        private void generateRandomValues()
        {
            Random rand = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {

                sb.Append((int)(rand.NextDouble() * 100)).Append(',');

            }
            txtValues.Text = sb.Remove(sb.Length - 1, 1).ToString();
        }

        private void btnSetValues_Click(object sender, EventArgs e)
        {
            
            threadAbort();

            for (int i = RobotContainer.Controls.Count - 1; i >= 0; i--)
                RobotContainer.Controls.RemoveAt(i);

            RobotContainer.Refresh();
            createRobot();
           
        }

      
       

       


        private void rbtnAscending_CheckedChanged(object sender, EventArgs e)
        {
            sortOrder = (rbtnAscending.Checked == true) ? ascending : descending;

        }
        //Run the Sort Algorithms on the Robot-- REFER TO THE SORT CLASS
        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            lblSort.Text = "Bubble Sort";
            threadAbort();
            r.Refresh();
            
            t = new Thread(delegate(){ s.BubbleSort(sortOrder); });
            t.Start(); // Sorting is done on a seperate thread . This keeps the UI thread responsive
        }

        private void btnInsertionSort_Click(object sender, EventArgs e)
        {
            lblSort.Text = "Insertion Sort";
            threadAbort();
            r.Refresh();
          
            t = new Thread(delegate() { s.InsertionSort(sortOrder); });
            t.Start();
           
        }

        private void btnSelectionSort_Click(object sender, EventArgs e)
        {
            lblSort.Text = "Selection Sort";
            threadAbort();
            r.Refresh();
           
           t = new Thread(delegate() { s.SelectionSort(sortOrder); });
            t.Start();
           
        }
        private void btnQSort_Click(object sender, EventArgs e)
        {
            lblSort.Text = "Quick Sort";


            threadAbort();
            r.Refresh();

            t = new Thread(delegate()
            {
                s.QuickSort(sortOrder, r.Elements, 0, r.Elements.Count - 1);
                MessageBox.Show("Sorted!", "QuickSort", MessageBoxButtons.OK, MessageBoxIcon.Information);
            });
            t.Start();


        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            threadAbort();
        }

        private void threadAbort()
        {
            if (t != null)
            {
                try { t.Abort(); }
                catch (ThreadStateException) { t.Resume(); }
                t = null;

            }
        }

        private void btnPauseResume_Click(object sender, EventArgs e)
        {

            if (t != null && t.ThreadState != ThreadState.Stopped)
            {
                r.pauseMarker = false;
                
                if (t.ThreadState == ThreadState.Suspended)
                    t.Resume();
                else
                    t.Suspend();
               

                

            }
            else
            {
                MessageBox.Show("Play an algorithm to Pause/Resume", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    

     
        private void btnRandomize_Click(object sender, EventArgs e)
        {
            generateRandomValues();
        }

        private void tbSpeed_Scroll(object sender, EventArgs e)
        {

            r.delay = tbSpeed.Maximum -tbSpeed.Value;
        }

      

       
        private void btnStep_Click(object sender, EventArgs e)
        {
            if (t != null && t.ThreadState != ThreadState.Stopped)
            {
                r.pauseMarker = true;


                if (t.ThreadState == ThreadState.Suspended)
                    t.Resume();
                else
                    
                        t.Suspend();
                
            }
            else
            {
                MessageBox.Show("Play an algorithm to Step", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developer: Haritha Wickremasinghe\nRegNo: IT12087020\n", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

      
      
    }
}
