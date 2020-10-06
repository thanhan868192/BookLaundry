using Booking_Laundry.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Booking_Laundry.Models.Dao
{
    public class OrderDao
    {
        private onlinelaundryEntities db = null;

        public OrderDao()
        {
            db = new onlinelaundryEntities();
        }

        public List<Order> GetOrders()
        {
            return db.Orders.ToList();
        }

        public Order GetOrderById(int id)
        {
            var data = db.Orders.Find(id);
            return data;
        }

        public bool CreateOrder(Order order)
        {
            db.Orders.Add(order);
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateOrder(Order order)
        {
            var data = db.Orders.SingleOrDefault(s => s.id == order.id);
            data.idCode = order.idCode;
            data.customerId = order.customerId;
            data.laundryTypeId = order.laundryTypeId;
            data.amountUnit = order.amountUnit;
            data.description = order.description;
            data.idDelivery = order.idDelivery;
            data.totalPayment = order.totalPayment;
            data.status = order.status;
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteOrder(int id)
        {
            var data = db.Orders.SingleOrDefault(s => s.id == id);
            db.Orders.Remove(data);
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }
    }
}