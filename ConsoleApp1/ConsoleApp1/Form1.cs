using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string text2 = inputBox2.Text;
        }

        private void inputBox1_TextChanged(object sender, EventArgs e)
        {
            string text1 =inputBox1.Text;

        }

        private void operatorButton_Click(object sender, EventArgs e)
        {
            double a=0,b=0;
            string aString =inputBox1.Text;
            string bString =inputBox2.Text;
            string myOperator =operatorBox.Text;
            if (myOperator.Length == 1)
            {
                double ?result ;
                switch (Convert.ToChar(myOperator))
                {
                    case '+':
                        result = a + b;
                        operatorBox.Text = Convert.ToString(result);
                        break;
                    case '-':
                        result = a - b;
                        operatorBox.Text = Convert.ToString(result);
                        break;
                    case '*':
                        result = a * b;
                        operatorBox.Text = Convert.ToString(result);
                        break;
                    case '/':
                        if (b == 0)
                        {
                           operatorBox.Text=("b should not be zero");
                            break;
                        }
                        result = a / b;
                        operatorBox.Text = Convert.ToString(result);
                        break;
                    default:
                        operatorBox.Text = ("not an operator");
                        break;

                }
            }
        }

        private void outputBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
