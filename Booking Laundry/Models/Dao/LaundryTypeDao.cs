
using Booking_Laundry.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Booking_Laundry.Models.Dao
{
    public class LaundryTypeDao
    {
        private onlinelaundryEntities db = null;

        public LaundryTypeDao()
        {
            db = new onlinelaundryEntities();
        }

        public List<LaundryType> GetLaundryTypes()
        {
            return db.LaundryTypes.ToList();
        }

        public LaundryType GetTypeById(int id)
        {
            var data = db.LaundryTypes.Find(id);
            return data;
        }

        public bool CreateLaundryType(LaundryType laundryType)
        {
            db.LaundryTypes.Add(laundryType);
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateLaundryType(LaundryType laundryType)
        {
            var data = db.LaundryTypes.SingleOrDefault(s => s.id == laundryType.id);
            data.init = laundryType.init;
            data.laundryName = laundryType.laundryName;
            data.price = laundryType.price;
            data.status = laundryType.status;
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteLaundryType(int id)
        {
            var data = db.LaundryTypes.SingleOrDefault(s => s.id == id);
            db.LaundryTypes.Remove(data);
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }
    }
}