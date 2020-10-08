using Booking_Laundry.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Booking_Laundry.Models.Dao
{
    public class DeliveryDao
    {
        private onlinelaundryEntities db = null;

        public DeliveryDao()
        {
            db = new onlinelaundryEntities();
        }

        public List<Delivery> GetDeliveries()
        {
            return db.Deliveries.ToList();
        }

        public Delivery GetDeliById(int id)
        {
            var data = db.Deliveries.Find(id);
            return data;
        }

        public bool CreateDeli(Delivery delivery)
        {
            db.Deliveries.Add(delivery);
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateDeli(Delivery delivery)
        {
            var data = db.Deliveries.SingleOrDefault(s => s.id == delivery.id);
            data.name = delivery.name;
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteDeli(int id)
        {
            var data = db.Deliveries.SingleOrDefault(s => s.id == id);
            db.Deliveries.Remove(data);
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }
    }
}