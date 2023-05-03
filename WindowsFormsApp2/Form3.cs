using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public void checkGUI()
        {
            for (int i = 0; i < Form2.n; i++)
            {
                if (guiList[i] == 1)
                {
                    DGV_visiblity.Rows[i].Cells[0].Value = "✅";

                }
                else if(guiList[i] == 0)
                    DGV_visiblity.Rows[i].Cells[0].Value = "❌";
            }
        }

        public static int[,] RemainingNeed = new int[Form2.n, Form2.m];
        public static bool[] finish = new bool[Form2.n] , oldVal = new bool[Form2.n];
        public static int[] guiList = new int[Form2.n];
        public static int[] safeSeq = new int[Form2.n];
        public static string work, notWork;
        public static int count = 0;
        public static bool found = false;
        public static int next = 1;
        
        public static void CalcRem()
        {
            for (int i = 0; i < Form2.n; i++)
            {
                for (int j = 0; j < Form2.m; j++)
                {
                    RemainingNeed[i, j] = Form1.Max[i, j] - Form1.CurrentAllocation[i, j];
                }
            }

            RemainingNeed[Form1.Process, Form1.ResType] -= Form1.ResNo;

        }
        public bool isSafe(int[] avail, int[,] maxm,
                        int[,] allot)
        {

            // Number of Processes
            int P = Form2.n;

            // Number of resources
            int R = Form2.m;

            int[,] need = Form3.RemainingNeed;


            // While all processes are not finished
            // or system is not in safe state.


            // Find a process which is not finish and
            // whose needs can be satisfied with current
            // work[] resources.
            int stepCount = 1;
            while (count < P)
            {
                found = false;
                for (int p = 0; p < P; p++)
                {
                    // First check if a process is finished,
                    // if no, go for next condition
                    if (finish[p] == false)
                    {
                        // Check if for all resources of
                        // current P need is less
                        // than work
                        int j;
                        char TypeResource = 'A';
                        for (j = 0; j < R; j++)
                        {

                            if (need[p, j] > avail[j])
                            {


                                guiList[p] = 0;
                                checkGUI();
                                MessageBox.Show("Process " + p + " will not work as it requests " + need[p, j] + " of Resource " + TypeResource + " while the avaliable is " + avail[j] , "Step" + stepCount  );
                                stepCount++;
                                break;
                            }
                            TypeResource++;
                        }



                        // If all needs of p were satisfied.
                        if (j == R)
                        {
                            // Add the allocated resources of
                            // current P to the available/work
                            // resources i.e.free the resources
                            for (int k = 0; k < R; k++)
                                avail[k] += allot[p, k];

                            for (int o = 0; o < Form2.m; o++)
                                DGV_avaliable.Rows[0].Cells[o].Value = avail[o];

                            // Add this process to safe sequence.
                            safeSeq[count++] = p;

                            // Mark this p as finished
                            finish[p] = true;
                            guiList[p] = 1;
                            found = true;

                            checkGUI();
                            MessageBox.Show("Process " + p + " will work as their requests is less than or equal the avaliable", "Step" + stepCount);
                            stepCount++;
                        }
                    }
                }
                if (found == false)
                {
                    result.Text = "System is not in safe state";
                    button1.Enabled = false;
                    return false;
                }
            }
            string x = "Safe Seq is  ";
            String seperator = ", ";
            result.Text = "System is in safe state";
            x += String.Join(seperator, safeSeq);
            safeSeq_label.Text = x;
            button1.Enabled = false;
            return true;
        }
        public Form3()
        {
            InitializeComponent();

            
            for (int i = 0; i < guiList.Length; i++)
            {
                guiList[i] = -1;
            }

            DataTable dt1 = new DataTable();//Remaining Need
            DataTable dt2 = new DataTable();//GUI steps
            DataTable dt3 = new DataTable();//inital Avaliable


            char x = 'A';
            dt1.Columns.Add(" ", typeof(string));
            //Resources
            for (int i = 0; i < Form2.m; i++)
            {
                dt1.Columns.Add("" + x + "", typeof(int));
                dt3.Columns.Add("" + x + "", typeof(int));
                x++;
            }

            dt3.Rows.Add(new object[] { });
            dt2.Columns.Add("Did it work?", typeof(string));
            //Processes 
            for (int j = 0; j < Form2.n; j++)
            {
                dt1.Rows.Add(new object[] { "P" + j });
                dt2.Rows.Add(new object[] {  });
            }

            DGV_rem.DataSource = dt1;
            DGV_visiblity.DataSource = dt2;
            DGV_avaliable.DataSource = dt3;
            DGV_visiblity.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            for (int i = 0; i < DGV_rem.Columns.Count; i++)
            {
                DGV_rem.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                
            }

            CalcRem();
            //inserting Values in the Remaining Need Table
            for (int i = 0; i < Form2.n; i++)
            {
                for (int j = 0; j < Form2.m; j++)
                {
                    DGV_rem.Rows[i].Cells[j+1].Value = RemainingNeed[i,j];
                }
            }

            for (int j = 0; j < Form2.m; j++)
            {
                
                DGV_avaliable.Rows[0].Cells[j].Value = Form1.Avaliable[j];
            }

            }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            isSafe(Form1.Avaliable, Form1.Max, Form1.CurrentAllocation);
        }

    }
}
