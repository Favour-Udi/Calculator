using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float num1, ans;
        int count;

        private void number1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void number2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void number3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void number4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void number5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void number6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void number7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void number8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void number9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 2;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 1;
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
        }

        private void divider_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
        }

        private void equalTo_Click(object sender, EventArgs e)
        {
            Compute(count);
        }
        public void Compute(int count)
        {
            switch(count)
            {
                case 1:
                    ans = num1 - float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 + float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 / float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                default:
                    break;


            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            count = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.ClearUndo();
        }

        private void period_Click(object sender, EventArgs e)
        {
            int c = textBox1.TextLength;
            int flag = 0;
            string text = textBox1.Text;
            for(int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1;
                    break;
                }
                else
                {
                    flag = 0;
                }
            if (flag == 0)
                {
                    textBox1.Text += ".";
                }
            }
        }

        private void number0_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }
    }
}
