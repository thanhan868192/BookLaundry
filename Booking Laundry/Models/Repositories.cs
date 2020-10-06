using Booking_Laundry.Models.Bus;
using Booking_Laundry.Models.Dto;
using Booking_Laundry.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Booking_Laundry.Models
{
    public class Repositories
    {
        #region Bill
        public IEnumerable<BillDto> GetBills()
        {
            return new BillBus().GetBills();
        }
        public BillDto GetBillById(int id)
        {
            return new BillBus().GetBillById(id);
        }
        public bool CreateBill(Bill bill)
        {
            if (new BillBus().CreateBill(bill))
            {
                return true;
            }
            return false;
        }
        public bool UpdateBill(Bill bill)
        {
            if (new BillBus().UpdateBill(bill))
            {
                return true;
            }
            return false;
        }

        public bool DeleteBill(int id)
        {
            if (new BillBus().DeleteBill(id))
            {
                return true;
            }
            return false;
        }
        #endregion
        #region Customer
        public IEnumerable<CustomerDto> GetCustomers()
        {
            return new CustomerBus().GetCustomers();
        }
        public CustomerDto GetCusById(int id)
        {
            return new CustomerBus().GetCusById(id);
        }
        public bool CreateCus(Customer customer)
        {
            if (new CustomerBus().CreateCus(customer))
            {
                return true;
            }
            return false;
        }
        public bool UpdateCus(Customer customer)
        {
            if (new CustomerBus().UpdateCus(customer))
            {
                return true;
            }
            return false;
        }

        public bool DeleteCus(int id)
        {
            if (new CustomerBus().DeleteCus(id))
            {
                return true;
            }
            return false;
        }
        #endregion
        #region Delivery
        public IEnumerable<DeliveryDto> GetDeliveries()
        {
            return new DeliveryBus().GetDeliveries();
        }
        public DeliveryDto GetDeliveryById(int id)
        {
            return new DeliveryBus().GetDeliveryById(id);
        }
        public bool CreateDeli(Delivery delivery)
        {
            if (new DeliveryBus().CreateDeli(delivery))
            {
                return true;
            }
            return false;
        }
        public bool UpdateDeli(Delivery delivery)
        {
            if (new DeliveryBus().UpdateDeli(delivery))
            {
                return true;
            }
            return false;
        }

        public bool DeleteDeli(int id)
        {
            if (new DeliveryBus().DeleteDeli(id))
            {
                return true;
            }
            return false;
        }
        #endregion
        #region LaundryType
        public IEnumerable<LaundryTypeDto> GetLaundryTypes()
        {
            return new LaundryTypeBus().GetLaundryTypes();
        }
        public LaundryTypeDto GetLaundryTypeById(int id)
        {
            return new LaundryTypeBus().GetLaundryTypeById(id);
        }
        public bool CreateLaundry(LaundryType laundryType)
        {
            if (new LaundryTypeBus().CreateLaundry(laundryType))
            {
                return true;
            }
            return false;
        }
        public bool UpdateLaundry(LaundryType laundryType)
        {
            if (new LaundryTypeBus().UpdateLaundry(laundryType))
            {
                return true;
            }
            return false;
        }

        public bool DeleteLaundry(int id)
        {
            if (new LaundryTypeBus().DeleteLaundry(id))
            {
                return true;
            }
            return false;
        }
        #endregion
        #region Order
        public IEnumerable<OrderDto> GetOrders()
        {
            return new OrderBus().GetOrders();
        }
        public OrderDto GetOrderById(int id)
        {
            return new OrderBus().GetOrderById(id);
        }
        public bool CreateOrder(Order order)
        {
            if (new OrderBus().CreateOrder(order))
            {
                return true;
            }
            return false;
        }
        public bool UpdateOrder(Order order)
        {
            if (new OrderBus().UpdateOrder(order))
            {
                return true;
            }
            return false;
        }

        public bool DeleteOrder(int id)
        {
            if (new OrderBus().DeleteOrder(id))
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}