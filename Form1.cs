using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Graphics graphics;
        int n=10;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        double length=100;
        Pen pen=Pens.Blue;
        Pen[] pens = new Pen[] { Pens.Red, Pens.Blue, Pens.Green, Pens.Black, Pens.Purple };

        void drawCayleyTree(int n,
                double x0, double y0, double leng, double th)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }
        void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(
                pen,
                (int)x0, (int)y0, (int)x1, (int)y1);
        }
        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pen = pens[this.comboBox1.SelectedIndex];
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        { 
        }
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            n = int.Parse(textBox1.Text);
            length = double.Parse(textBox2.Text);
            per1 = double.Parse(textBox3.Text);
            per2 = double.Parse(textBox4.Text);
            th1 = double.Parse(textBox5.Text)*Math.PI/180;
            th2 = double.Parse(textBox6.Text) * Math.PI / 180;
            drawCayleyTree(n, splitContainer1.Panel1.Width-200, splitContainer1.Panel1.Height-100, length, -Math.PI / 2);
           
           
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
          
            this.textBox1.Refresh();
            this.textBox2.Refresh();
            this.textBox3.Refresh();
            this.textBox4.Refresh();
            this.textBox5.Refresh();
            this.textBox6.Refresh();
            this.comboBox1.Refresh();
            this.panel1.Refresh();

        }
        
    }
}
