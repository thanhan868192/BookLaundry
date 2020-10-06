using Booking_Laundry.Models.Dao;
using Booking_Laundry.Models.Dto;
using Booking_Laundry.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Booking_Laundry.Models.Bus
{
    public class DeliveryBus
    {

        public IEnumerable<DeliveryDto> GetDeliveries()
        {
            var data = new DeliveryDao().GetDeliveries().Select(s => new DeliveryDto
            {
                id = s.id,
                name = s.name,
            });
            return data;
        }
        public DeliveryDto GetDeliveryById(int id)
        {
            var s = new DeliveryDao().GetDeliById(id);
            return new DeliveryDto
            {
                id = s.id,
                name = s.name,
            };
        }

        public bool CreateDeli(Delivery delivery)
        {
            if (new DeliveryDao().CreateDeli(delivery))
            {
                return true;
            }
            return false;
        }
        public bool UpdateDeli(Delivery delivery)
        {
            if (new DeliveryDao().UpdateDeli(delivery))
            {
                return true;
            }
            return false;
        }

        public bool DeleteDeli(int id)
        {
            if (new DeliveryDao().DeleteDeli(id))
            {
                return true;
            }
            return false;
        }
    }
}