using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flex_Trainer
{
    public partial class GEN_Reports : Form
    {
        public GEN_Reports()
        {
            InitializeComponent();
        }

        private void GEN_Reports_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            report1 report1 = new report1();
            report1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            report2 report2 = new report2();
            report2.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            report3 report3 = new report3();
            report3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            report5 report5 = new report5();
            report5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            report6 report6 = new report6();
            report6.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            report7 report7 = new report7();
            report7.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            report8 report8 = new report8();
            report8.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            report10 report10 = new report10();
            report10.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            report9 report9 = new report9();
            report9.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            report11 report11 = new report11();
            report11.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            report12 report_12 = new report12();
            report_12.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            report13 report13 = new report13();
            report13.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            report14 report14 = new report14();
            report14.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            report15 report15 = new report15();
            report15.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            report16 report16 = new report16();
            report16.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            report17 report17 = new report17();
            report17.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            report18 report18 = new report18();
            report18.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            report19 report19 = new report19();
            report19.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            report20 report201 = new report20();
            report201.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            report4 report4 = new report4();
            report4.Show();
        }
    }
}
