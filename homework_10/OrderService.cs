using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace program1
{
    public class OrderService
    {
        public void Add(Order order)
        {
            using (var data_1 = new ordersql())
            {
                data_1.Order.Add(order);
                data_1.SaveChanges();
            }
        }

        public void Delete(String orderId)
        {
            using (var data_1 = new ordersql())
            {
                var order = data_1.Order.Include("Details").SingleOrDefault(o => o.Id.ToString() == orderId);
                data_1.OrderDetails.RemoveRange(order.Details);
                data_1.Order.Remove(order);
                data_1.SaveChanges();
            }
        }

        public void Update(Order order)
        {
            using (var data_1 = new ordersql())
            {
                data_1.Order.Attach(order);
                data_1.Entry(order).State = EntityState.Modified;
                order.Details.ForEach(
                    Details => data_1.Entry(Details).State = EntityState.Modified);
                data_1.SaveChanges();
            }
        }

        public Order GetOrder(String Id)
        {
            using (var data_1 = new ordersql())
            {
                return data_1.Order.Include("Details").
                  SingleOrDefault(o => o.Id.ToString() == Id);
            }
        }

        public List<Order> GetAllOrders()
        {
            using (var data_1 = new ordersql())
            {
                return data_1.Order.Include("Details").ToList<Order>();
            }
        }

    }
}
