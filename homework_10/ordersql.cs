using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class ordersql:DbContext
    {
        public ordersql() : base("OrderDataBase") { }

        public DbSet<Order> Order { get; set; }

        public DbSet<OrderDetails> OrderDetails { get; set; }

        public DbSet<Goods> goods { get; set; }
    }
}
