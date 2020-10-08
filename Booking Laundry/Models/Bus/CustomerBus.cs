using Booking_Laundry.Models.Dao;
using Booking_Laundry.Models.Dto;
using Booking_Laundry.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Booking_Laundry.Models.Bus
{
    public class CustomerBus
    {
        public IEnumerable<CustomerDto> GetCustomers()
        {
            var data = new CustomerDao().GetCustomers().OrderByDescending(d=> d.id).Select(s => new CustomerDto
            {
                id = s.id,
                idCode = s.idCode,
                fullName = s.fullName,
                phoneNumber = s.phoneNumber,
                address = s.address,
                gender = s.gender,
                status = s.status
            });
            return data;
        }
        public CustomerDto GetCusById(int id)
        {
            var s = new CustomerDao().GetCusById(id);
            return new CustomerDto 
            {
                id = s.id,
                idCode = s.idCode,
                fullName = s.fullName,
                phoneNumber = s.phoneNumber,
                address = s.address,
                gender = s.gender,
                status = s.status
            };
        } 

        public bool CreateCus(Customer customer)
        {
            if (new CustomerDao().CreateCus(customer))
            {
                return true;
            }
            return false;
        }
        public bool UpdateCus(Customer customer)
        {
            if (new CustomerDao().UpdateCus(customer))
            {
                return true;
            }
            return false;
        }

        public bool DeleteCus(int id)
        {
            if (new CustomerDao().DeleteCus(id))
            {
                return true;
            }
            return false;
        }
    }
}