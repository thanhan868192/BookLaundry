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
            var data = new OrderDao().GetOrders().OrderByDescending(d=>d.id).Select(s => new OrderDto
            {
                id = s.id,
                idCode = s.idCode,
                customerId = s.customerId,
                laundryTypeId = s.laundryTypeId,
                amountUnit = s.amountUnit,
                description = s.description,
                totalPayment = s.totalPayment,
                status = s.status,
                idDelivery = s.idDelivery,
                CustomerDto = new CustomerDto
                {
                    id = s.Customer.id,
                    fullName = s.Customer.fullName
                },
                LaundryTypeDto = new LaundryTypeDto
                {
                    id = s.LaundryType.id,
                    laundryName = s.LaundryType.laundryName
                },
                DeliveryDto = new DeliveryDto 
                {
                    id = s.Delivery.id,
                    name = s.Delivery.name
                },
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
                status = s.status,
                CustomerDto = new CustomerDto
                {
                    id = s.Customer.id,
                    fullName = s.Customer.fullName
                },
                LaundryTypeDto = new LaundryTypeDto
                {
                    laundryName = s.LaundryType.laundryName
                },
            };
        }

        public bool CreateOrder(Order order)
        {
            order.idDelivery = 1;
            order.status = "inactive";
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