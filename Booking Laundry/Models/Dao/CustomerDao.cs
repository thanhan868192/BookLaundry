using Booking_Laundry.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Booking_Laundry.Models.Dao
{
    public class CustomerDao
    {
        private onlinelaundryEntities db = null;

        public CustomerDao()
        {
            db = new onlinelaundryEntities();
        }

        public List<Customer> GetCustomers()
        {
            return db.Customers.ToList();
        }

        public Customer GetCusById(int id)
        {
            var data = db.Customers.Find(id);
            return data;
        }

        public bool CreateCus(Customer customer)
        {
            db.Customers.Add(customer);
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateCus(Customer customer)
        {
            var data = db.Customers.SingleOrDefault(s => s.id == customer.id);
            data.fullName = customer.fullName;
            data.idCard = customer.idCard;
            data.phoneNumber = customer.phoneNumber;
            data.address = customer.address;
            data.gender = customer.gender;
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteCus(int id)
        {
            var data = db.Customers.SingleOrDefault(s => s.id == id);
            db.Customers.Remove(data);
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }
    }
}