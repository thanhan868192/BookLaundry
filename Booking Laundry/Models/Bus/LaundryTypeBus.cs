using Booking_Laundry.Models.Dao;
using Booking_Laundry.Models.Dto;
using Booking_Laundry.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Booking_Laundry.Models.Bus
{
    public class LaundryTypeBus
    {
        public IEnumerable<LaundryTypeDto> GetLaundryTypes()
        {
            var data = new LaundryTypeDao().GetLaundryTypes().OrderByDescending(d=> d.id).Select(s => new LaundryTypeDto
            {
                id = s.id,
                laundryName = s.laundryName,
                price= s.price,
                init = s.init,
                status = s.status
            });
            return data;
        }
        public LaundryTypeDto GetLaundryTypeById(int id)
        {
            var s = new LaundryTypeDao().GetTypeById(id);
            return new LaundryTypeDto
            {
                id = s.id,
                laundryName = s.laundryName,
                price = s.price,
                init = s.init,
                status = s.status
            };
        }

        public bool CreateLaundry(LaundryType laundryType)
        {
            if (new LaundryTypeDao().CreateLaundryType(laundryType))
            {
                return true;
            }
            return false;
        }
        public bool UpdateLaundry(LaundryType laundryType)
        {
            if (new LaundryTypeDao().UpdateLaundryType(laundryType))
            {
                return true;
            }
            return false;
        }

        public bool DeleteLaundry(int id)
        {
            if (new LaundryTypeDao().DeleteLaundryType(id))
            {
                return true;
            }
            return false;
        }
    }
}