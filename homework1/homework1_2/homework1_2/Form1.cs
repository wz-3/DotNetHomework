using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double a, b;
            char operate;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            operate = Convert.ToChar(comboBox1.SelectedItem.ToString());
            switch (operate)
            {
                case '+':
                    label1.Text = (a + b).ToString();
                    break;
                case '-':
                    label1.Text = (a - b).ToString();
                    break;
                case '*':
                    label1.Text = (a * b).ToString();
                    break;
                case '/':
                    label1.Text = (a / b).ToString();
                    break;
                case '%':
                    label1.Text = (a % b).ToString();
                    break;
            }
        }
    }
}
