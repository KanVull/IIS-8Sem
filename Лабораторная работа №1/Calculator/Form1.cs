using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private bool hasSeparator = false;
        private bool zeroFirst = true;
        private enum clAction {acNone, acAdd, acSub, acMul, acDiv, acEqual};
        private clAction act = clAction.acNone;
        private double x = 0;
        private double y = 0;
        private double f = 0;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void button16_Click(object sender, EventArgs e)
        {
            hasSeparator = false;
            zeroFirst = true;
            act = clAction.acNone;
            x = 0;
            y = 0;
            f = 0;
            textBox1.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (act == clAction.acEqual) return;

            if (!hasSeparator)
            {
                textBox1.Text = textBox1.Text + ",";
                hasSeparator = true;
                zeroFirst = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (act == clAction.acEqual) return;

            if (!zeroFirst)
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (act == clAction.acEqual) return;

            if (zeroFirst)
            {
                textBox1.Text = "1";
                zeroFirst = false;
            }
            else
                textBox1.Text = textBox1.Text + "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (act == clAction.acEqual) return;

            if (zeroFirst)
            {
                textBox1.Text = "2";
                zeroFirst = false;
            }
            else
                textBox1.Text = textBox1.Text + "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (act == clAction.acEqual) return;

            if (zeroFirst)
            {
                textBox1.Text = "3";
                zeroFirst = false;
            }
            else
                textBox1.Text = textBox1.Text + "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (act == clAction.acEqual) return;

            if (zeroFirst)
            {
                textBox1.Text = "4";
                zeroFirst = false;
            }
            else
                textBox1.Text = textBox1.Text + "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (act == clAction.acEqual) return;

            if (zeroFirst)
            {
                textBox1.Text = "5";
                zeroFirst = false;
            }
            else
                textBox1.Text = textBox1.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (act == clAction.acEqual) return;

            if (zeroFirst)
            {
                textBox1.Text = "6";
                zeroFirst = false;
            }
            else
                textBox1.Text = textBox1.Text + "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (act == clAction.acEqual) return;

            if (zeroFirst)
            {
                textBox1.Text = "7";
                zeroFirst = false;
            }
            else
                textBox1.Text = textBox1.Text + "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (act == clAction.acEqual) return;

            if (zeroFirst)
            {
                textBox1.Text = "8";
                zeroFirst = false;
            }
            else
                textBox1.Text = textBox1.Text + "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (act == clAction.acEqual) return;

            if (zeroFirst)
            {
                textBox1.Text = "9";
                zeroFirst = false;
            }
            else
                textBox1.Text = textBox1.Text + "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (act == clAction.acNone || act == clAction.acEqual)
            {
                x = Convert.ToDouble(textBox1.Text);
                act = clAction.acDiv;
                hasSeparator = false;
                zeroFirst = true;
                textBox1.Text = "0";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (act == clAction.acNone || act == clAction.acEqual)
            {
                x = Convert.ToDouble(textBox1.Text);
                act = clAction.acMul;
                hasSeparator = false;
                zeroFirst = true;
                textBox1.Text = "0";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (act == clAction.acNone || act == clAction.acEqual)
            {
                x = Convert.ToDouble(textBox1.Text);
                act = clAction.acSub;
                hasSeparator = false;
                zeroFirst = true;
                textBox1.Text = "0";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (act == clAction.acNone || act == clAction.acEqual)
            {
                x = Convert.ToDouble(textBox1.Text);
                act = clAction.acAdd;
                hasSeparator = false;
                zeroFirst = true;
                textBox1.Text = "0";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (act != clAction.acNone)
            {
                y = Convert.ToDouble(textBox1.Text);

                CalcServiceReference.CalcServiceSoapClient s = new CalcServiceReference.CalcServiceSoapClient();
                switch (act)
                {
                    case clAction.acAdd: 
                        f = s.Add(x, y);
                        break;
                    case clAction.acSub: 
                        f = s.Sub(x, y);
                        break;
                    case clAction.acMul:
                        f = s.Mul(x, y);
                        break;
                    case clAction.acDiv:
                        f = s.Div(x, y);
                        break;
                }

                x = f;
                act = clAction.acEqual;
                textBox1.Text = Convert.ToString(f);
            }
        }


    }
}
