using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        DataTable dt4 = new DataTable();

        public static int[,] Max = new int[Form2.n, Form2.m], CurrentAllocation = new int[Form2.n, Form2.m];
        public static int[] Avaliable = new int[Form2.m], Total = new int[Form2.m];

        public static int ResNo;
        public static int Process;
        public static int ResType;
        public bool TotalCheck()
        {
            for (int i = 0; i < Form2.m; i++)
            {
                int check = 0;
                for (int j = 0; j < Form2.n; j++)
                {
                    check += CurrentAllocation[j, i];

                }
                if (Total[i] != check + Avaliable[i])
                {
                    //The user has  made a miscalculation
                    MessageBox.Show("The System has a miscalculation");
                    return true;
                }
            }
            return false;
        }

        public bool RemCheck()
        {
            Form3.CalcRem();
            //Compare max with the current to make sure that the input is correct
            for (int i = 0; i < Form2.n; i++)
            {
                for (int j = 0; j < Form2.m; j++)
                {
                    if (Form3.RemainingNeed[i, j] < 0)
                    {
                        MessageBox.Show("The System has a miscalculation");
                        return true;
                    }
                }
            }

            return false;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SampleEmaple_btn_Click(object sender, EventArgs e)
        {
            //example 1
            if (Form2.n == 5 && Form2.m == 3)
            {
                int[,] allot ={{ 0, 1, 0 }, //P0
                        { 2, 0, 0 }, //P1
                        { 3, 0, 2 }, //P2
                        { 2, 1, 1 }, //P3
                        { 0, 0, 2 }};//P4
                int[,] max = {{ 7, 5, 3 }, //P0
                        { 3, 2, 2 }, //P1
                      { 9, 0, 2 }, //P2
                      { 2, 2, 2 }, //P3
                      { 4, 3, 3 }};//P4
                int[] avaliable = { 3, 3, 2 };
                int[] total = { 10, 5, 7 };
                for (int i = 0; i < Form2.n; i++)
                {
                    for (int j = 0; j < Form2.m; j++)
                    {
                        DGV_max.Rows[i].Cells[j + 1].Value = max[i, j];
                        DGV_allot.Rows[i].Cells[j + 1].Value = allot[i, j];
                    }
                }
                for (int j = 0; j < Form2.m; j++)
                {
                    DGV_avaliable.Rows[0].Cells[j].Value = avaliable[j];
                    DGV_total.Rows[0].Cells[j].Value = total[j];
                }
                comboBox_process.SelectedIndex = 1;
                comboBox_res.SelectedIndex = 1;
            }

        }

        public Form1()
        {
            InitializeComponent();

            if (Form2.n != 5 || Form2.m != 3)
            {
                SampleEmaple_btn.Enabled = false;
            }

            char x = 'A';
            dt1.Columns.Add(" ", typeof(string));
            dt2.Columns.Add(" ", typeof(string));
            //Resources
            for (int i = 0; i < Form2.m; i++)
            {
                dt1.Columns.Add("" + x + "", typeof(int));
                dt2.Columns.Add("" + x + "", typeof(int));
                dt3.Columns.Add("" + x + "", typeof(int));
                dt4.Columns.Add("" + x + "", typeof(int));
                comboBox_res.Items.Add("" + x + "");
                x++;
            }


            dt3.Rows.Add(new object[] { });
            dt4.Rows.Add(new object[] { });


            DGV_avaliable.DataSource = dt3;
            DGV_total.DataSource = dt4;
            //Processes
            for (int j = 0; j < Form2.n; j++)
            {
                dt1.Rows.Add(new object[] { "P" + j });
                dt2.Rows.Add(new object[] { "P" + j });
                comboBox_process.Items.Add("P" + j);

            }
            DGV_max.DataSource = dt1;
            DGV_allot.DataSource = dt2;


            for (int i = 0; i < DGV_max.Columns.Count; i++)
            {
                DGV_max.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                DGV_allot.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }


            DGV_max.Columns[0].ReadOnly = true;
            DGV_allot.Columns[0].ReadOnly = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool Flag = false;
            bool FlagNeg = false;

            for (int i = 0; i < Form2.n; i++)
            {
                if (Flag == true || FlagNeg == true)
                {
                    break;
                }
                for (int j = 0; j < Form2.m; j++)
                {
                    if (DGV_max.Rows[i].Cells[j + 1].Value == DBNull.Value)
                    {
                        FillTable_lbl.Visible = true;
                        Flag = true;
                        break;
                    }
                    else if (DGV_allot.Rows[i].Cells[j + 1].Value == DBNull.Value)
                    {
                        FillTable_lbl.Visible = true;
                        Flag = true;
                        break;
                    }
                    else if ((int)DGV_max.Rows[i].Cells[j + 1].Value < 0 || (int)DGV_allot.Rows[i].Cells[j + 1].Value < 0)
                    {
                        FlagNeg = true;
                        MessageBox.Show("Please only Enter Postive integers");

                        break;
                    }

                    else
                    {
                        Max[i, j] = (int)DGV_max.Rows[i].Cells[j + 1].Value;
                        CurrentAllocation[i, j] = (int)DGV_allot.Rows[i].Cells[j + 1].Value;
                    }

                }
            }

            for (int j = 0; j < Form2.m; j++)
            {
                if (DGV_avaliable.Rows[0].Cells[j].Value == DBNull.Value)
                {
                    Flag = true;
                    FillTable_lbl.Visible = true;

                    break;
                }
                else if (DGV_total.Rows[0].Cells[j].Value == DBNull.Value)
                {
                    Flag = true;
                    FillTable_lbl.Visible = true;
                    break;
                }
                else if ((int)DGV_total.Rows[0].Cells[j].Value < 0 || (int)DGV_avaliable.Rows[0].Cells[j].Value < 0)
                {
                    FlagNeg = true;
                    MessageBox.Show("Please only Enter Postive integers");
                    break;
                }
                else
                {
                    Avaliable[j] = (int)DGV_avaliable.Rows[0].Cells[j].Value;
                    Total[j] = (int)DGV_total.Rows[0].Cells[j].Value;
                }

            }


            if (comboBox_process.SelectedIndex < 0 || comboBox_res.SelectedIndex < 0)
            {
                Flag = true;
                MessageBox.Show("Please choose a Process and a Resource in the combo boxes. ");
            }
            else if (FlagNeg == false && Flag == false && RemCheck() == false && TotalCheck() == false)
            {

                FillTable_lbl.Visible = false;

                ResNo = (int)NumericUpDown_ResNo.Value;
                Process = comboBox_process.SelectedIndex;
                ResType = comboBox_res.SelectedIndex;
                Form3 f3 = new Form3();
                f3.ShowDialog(); // Shows Form3
            }

        }




    }
}

