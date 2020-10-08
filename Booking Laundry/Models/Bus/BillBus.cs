using Booking_Laundry.Models.Dao;
using Booking_Laundry.Models.Dto;
using Booking_Laundry.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Booking_Laundry.Models.Bus
{
    public class BillBus
    {
        public IEnumerable<BillDto> GetBills()
        {
            var data = new BillDao().GetBills().OrderBy(d=>d.dateCreate).Select(s => new BillDto
            {
                id = s.id,
                idCode = s.idCode,
                dateCreate = s.dateCreate,
                totalExpenses = s.totalExpenses,
                status = s.status
            });
            return data;
        }
        public BillDto GetBillById(int id)
        {
            var s = new BillDao().GetBillById(id);
            return new BillDto
            {
                id = s.id,
                idCode = s.idCode,
                dateCreate = s.dateCreate,
                totalExpenses = s.totalExpenses,
                status = s.status
            };
        }

        public bool CreateBill(Bill bill)
        {
            if (new BillDao().CreateBill(bill))
            {
                return true;
            }
            return false;
        }
        public bool UpdateBill(Bill bill)
        {
            if (new BillDao().UpdateBill(bill))
            {
                return true;
            }
            return false;
        }

        public bool DeleteBill(int id)
        {
            if (new BillDao().DeleteBill(id))
            {
                return true;
            }
            return false;
        }
    }
}