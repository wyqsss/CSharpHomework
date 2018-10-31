using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            int num = int.Parse(s);
            for(int i = 2;i<=num;i++)
            {
                if(num%i==0)
                {
                    num = num / i;
                    while (num % i == 0)
                        num = num / i;
                    label2.Text = label2.Text +" "+i;
                }
            }
        }
    }
}
