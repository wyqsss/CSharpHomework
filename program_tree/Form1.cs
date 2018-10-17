using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program_tree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Graphics graphics;
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            drawCayleyTree(10, 300, 310, 100, -Math.PI / 2);
            
        }
        void drawCayleyTree(int n,double x0,double y0,double leng,double th)
        {
            double th1 = Double.Parse(textBox1.Text)*Math.PI/180;
            double th2 = Double.Parse(textBox2.Text)*Math.PI/180;
            double per1 = Double.Parse(textBox3.Text);
            double per2 = Double.Parse(textBox4.Text);
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            Random r = new Random();
            double x2 = x0 + leng * 0.5 * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            double y2 = y0 + leng * 0.5 * Math.Sin(th);
            drawLine(x0, y0, x1, y1);
            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x2, y2, per2 * leng, th - th2);

        }
        void drawLine(double x0,double y0,double x1,double y1)
        {
            graphics.DrawLine(Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1);
        }
       
    }
}
