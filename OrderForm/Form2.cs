using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ordertest;
namespace OrderForm
{
    public partial class Form2 : Form
    {

        public Form2()
        {
           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long Id = long.Parse(textBox1.Text);
            string s_1 = textBox2.Text;
            string s_2 = textBox3.Text;
             uint num = uint.Parse(textBox4.Text);
            double price = double.Parse(textBox5.Text);
            Customer customer4 = new Customer(4, s_1);
            Goods g_1 = new Goods(4, s_2, price);
            OrderDetail orderdetail4 = new OrderDetail(4, g_1, num);
            Order order4 = new Order(4, customer4);
            order4.AddDetails(orderdetail4);
            Form1.os.AddOrder(order4);
                       
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
