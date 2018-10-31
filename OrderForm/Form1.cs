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
    public partial class Form1 : Form
    {
        public static OrderService os;
        public Form1()
        {
            Customer customer1 = new Customer(1, "Customer1");
            Customer customer2 = new Customer(2, "Customer2");
            Customer customer3 = new Customer(3, "Custumer3");
            Goods milk = new Goods(1, "Milk", 69.9);
            Goods eggs = new Goods(2, "eggs", 4.99);
            Goods apple = new Goods(3, "apple", 5.59);

            OrderDetail orderDetails1 = new OrderDetail(1, apple, 8);
            OrderDetail orderDetails2 = new OrderDetail(2, eggs, 2);
            OrderDetail orderDetails3 = new OrderDetail(3, milk, 1);

            Order order1 = new Order(1, customer1);
            Order order2 = new Order(2, customer2);
            Order order3 = new Order(3, customer3);
            order1.AddDetails(orderDetails1);
            //order1.AddOrderDetails(orderDetails3);
            order2.AddDetails(orderDetails2);
            order3.AddDetails(orderDetails3);

            os = new OrderService();
            os.AddOrder(order1);
            os.AddOrder(order2);
            os.AddOrder(order3);
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 myform = new Form2();
            myform.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string s_1 = textBox1.Text;
            
            List<Order> orders = os.QueryAllOrders();
            foreach (Order od in orders)
            {
                if(od.Customer.Name==s_1)
                {
                    label2.Text = s_1;
                    label3.Text = od.Id.ToString();
                    break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
