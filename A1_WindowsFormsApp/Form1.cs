using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client sc = new ServiceReference1.Service1Client();
            string var;
            int num;
            int calcNum;
            var = textBox1.Text;
            num = Int32.Parse(var);
            calcNum = sc.c2f(num);
            button1.Text = "DONE! Click me again for new Caluculation";
            button2.Text = calcNum + "";


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client sc = new ServiceReference1.Service1Client();
            string var;
            int num;
            int calcNum;
            var = textBox2.Text;
            num = Int32.Parse(var);
            calcNum = sc.f2c(num);
            button4.Text = "DONE! Click me again for new Caluculation";
            button3.Text = calcNum + "";
        }
    }
}
