using Booking_Laundry.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Booking_Laundry.Models.Dao
{
    public class BillDao
    {
        private onlinelaundryEntities db = null;

        public BillDao()
        {
            db = new onlinelaundryEntities();
        }

        public List<Bill> GetBills()
        {
            return db.Bills.ToList();
        }

        public Bill GetBillById(int id)
        {
            var data = db.Bills.Find(id);
            return data;
        }

        public bool CreateBill(Bill bill    )
        {
            db.Bills.Add(bill);
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateBill(Bill bill)
        {
            var data = db.Bills.SingleOrDefault(s => s.id == bill.id);
            data.id = bill.id;
            data.dateCreate = bill.dateCreate;
            data.totalExpenses = bill.totalExpenses;
            data.status = bill.status;
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteBill(int id)
        {
            var data = db.Bills.SingleOrDefault(s => s.id == id);
            db.Bills.Remove(data);
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }
    }
}