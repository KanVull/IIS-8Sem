using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ServiceReference1.WebService1SoapClient s;
        private void Button1_Click(object sender, EventArgs e)
        {
            s = new ServiceReference1.WebService1SoapClient();

            double value = double.Parse(textBox1.Text);
            byte r1 = 1, r2 = 2;
            if (radioButton1.Checked) r1 = 1;
            if (radioButton2.Checked) r1 = 2;
            if (radioButton3.Checked) r1 = 3;
            if (radioButton4.Checked) r2 = 1;
            if (radioButton5.Checked) r2 = 2;
            if (radioButton6.Checked) r2 = 3;
            textBox2.Text = s.GetValue(value, r1, r2).ToString(); 
        }
    }
}
