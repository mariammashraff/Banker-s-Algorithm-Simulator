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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static int m = new int(); //No of Resouces 
        public static int n = new int(); //No of Process

        private void button1_Click(object sender, EventArgs e)
        {
            n = (int)NoProcess.Value;

         
            m = (int)NoResource.Value;

            Form1 f1 = new Form1();
            f1.ShowDialog(); // Shows Form1

        }

        private void button3_Click(object sender, EventArgs e)
        {
            NoProcess.Value = 5;
            n = 5;
            m = 3;
            NoResource.Value = 3;
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}
