using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class CalculatorApp : Form
    {
        double firstNum;
        string operation;
        public CalculatorApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void num0_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "0";
        }

        private void num1_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0" && txtBox.Text != null)
            {
                txtBox.Text = "1";
            }
            else
            {
                txtBox.Text += "1";
            }
        }

        private void num2_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0" && txtBox.Text != null)
            {
                txtBox.Text = "2";
            }
            else
            {
                txtBox.Text += "2";
            }
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0" && txtBox.Text != null)
            {
                txtBox.Text = "3";
            }
            else
            {
                txtBox.Text += "3";
            }
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0" && txtBox.Text != null)
            {
                txtBox.Text = "4";
            }
            else
            {
                txtBox.Text += "4";
            }
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0" && txtBox.Text != null)
            {
                txtBox.Text = "5";
            }
            else
            {
                txtBox.Text += "5";
            }
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0" && txtBox.Text != null)
            {
                txtBox.Text = "6";
            }
            else
            {
                txtBox.Text += "6";
            }
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0" && txtBox.Text != null)
            {
                txtBox.Text = "7";
            }
            else
            {
                txtBox.Text += "7";
            }
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0" && txtBox.Text != null)
            {
                txtBox.Text = "8";
            }
            else
            {
                txtBox.Text += "8";
            }
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0" && txtBox.Text != null)
            {
                txtBox.Text = "9";
            }
            else
            {
                txtBox.Text += "9";
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(txtBox.Text);
            txtBox.Text = "0";
            operation = "+";
        }

        private void subractBtn_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(txtBox.Text);
            txtBox.Text = "0";
            operation = "-";
        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(txtBox.Text);
            txtBox.Text = "0";
            operation = "*";
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(txtBox.Text);
            txtBox.Text = "0";
            operation = "/";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBox.Text = "0";
        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + ".";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double secondNum;
            double result;

            secondNum = Convert.ToDouble(txtBox.Text);

            if (operation == "+")
            {
                result = (firstNum + secondNum);
                txtBox.Text = Convert.ToString(result);
                firstNum = result;
            }
            if (operation == "-")
            {
                result = (firstNum - secondNum);
                txtBox.Text = Convert.ToString(result);
                firstNum = result;
            }
            if (operation == "*")
            {
                result = (firstNum * secondNum);
                txtBox.Text = Convert.ToString(result);
                firstNum = result;
            }
            if (operation == "/")
            {
                if (secondNum == 0)
                {
                    txtBox.Text = "Cannot divide by zero";

                }
                else
                {
                    result = (firstNum / secondNum);
                    txtBox.Text = Convert.ToString(result);
                    firstNum = result;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
