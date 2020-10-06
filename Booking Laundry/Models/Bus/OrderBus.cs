using Booking_Laundry.Models.Dao;
using Booking_Laundry.Models.Dto;
using Booking_Laundry.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Booking_Laundry.Models.Bus
{
    public class OrderBus
    {
        public IEnumerable<OrderDto> GetOrders()
        {
            var data = new OrderDao().GetOrders().Select(s => new OrderDto
            {
                id = s.id,
                idCode = s.idCode,
                customerId = s.customerId,
                laundryTypeId = s.laundryTypeId,
                amountUnit = s.amountUnit,
                description = s.description,
                totalPayment = s.totalPayment,
                status = s.status
            });
            return data;
        }
        public OrderDto GetOrderById(int id)
        {
            var s = new OrderDao().GetOrderById(id);
            return new OrderDto
            {
                id = s.id,
                idCode = s.idCode,
                customerId = s.customerId,
                laundryTypeId = s.laundryTypeId,
                amountUnit = s.amountUnit,
                description = s.description,
                totalPayment = s.totalPayment,
                status = s.status
            };
        }

        public bool CreateOrder(Order order)
        {
            if (new OrderDao().CreateOrder(order))
            {
                return true;
            }
            return false;
        }
        public bool UpdateOrder(Order order)
        {
            if (new OrderDao().UpdateOrder(order))
            {
                return true;
            }
            return false;
        }

        public bool DeleteOrder(int id)
        {
            if (new OrderDao().DeleteOrder(id))
            {
                return true;
            }
            return false;
        }
    }
}