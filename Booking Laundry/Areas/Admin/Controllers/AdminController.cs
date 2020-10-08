using Booking_Laundry.Models;
using Booking_Laundry.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Booking_Laundry.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin/Admin
        public ActionResult Index()
        {
            return View();
        }
        #region LaundryType
        public ActionResult LaundryType()
        {
            var data = new Repositories().GetLaundryTypes();
            return View(data);
        }

        public ActionResult ViewCreateLaundry()
        {
            return View();
        }

        public ActionResult CreateLaundry(LaundryType laundryType)
        {
            if (laundryType != null)
            {
                new Repositories().CreateLaundry(laundryType);
                return RedirectToAction("Detail", new {id = laundryType.id });
            }
            return RedirectToAction("ViewCreateLaundry");
        }

        public ActionResult Edit(int id)
        {
            var data = new Repositories().GetLaundryTypeById(id);
            return View(data);
        }

        public ActionResult UpdateLaundry(LaundryType laundryType)
        {
            if (laundryType != null)
            {
                new Repositories().UpdateLaundry(laundryType);
                return RedirectToAction("Detail", new { id = laundryType.id });
            }
            return RedirectToAction("Edit", new { id = laundryType.id });
        }

        public ActionResult DeleteLaundry(int id)
        {
            new Repositories().DeleteLaundry(id);
            return RedirectToAction("LaundryType");
        }

        public ActionResult Detail(int id)
        {
            var data = new Repositories().GetLaundryTypeById(id);
            return View(data);
        }

        #endregion
        #region Customer
         public ActionResult Customer()
        {
            var data = new Repositories().GetCustomers();
            return View(data);
        }

        public ActionResult ViewCreateCus()
        {
            return View();
        }

        public ActionResult CreateCus(Customer customer)
        {
            if (customer != null)
            {
                int num = new Random().Next(10000, 99990);
                customer.idCode = num.ToString();
                new Repositories().CreateCus(customer);
                return RedirectToAction("DetailCus", new {id = customer.id });
            }
            return RedirectToAction("ViewCreateCus");
        }

        public ActionResult EditCus(int id)
        {
            var data = new Repositories().GetCusById(id);
            return View(data);
        }

        public ActionResult UpdateCus(Customer customer)
        {
            if (customer != null)
            {
                new Repositories().UpdateCus(customer);
                return RedirectToAction("DetailCus", new { id = customer.id });
            }
            return RedirectToAction("EditCus", new { id = customer.id });
        }

        public ActionResult DeleteCus(int id)
        {
            new Repositories().DeleteCus(id);
            return RedirectToAction("Customer");
        }

        public ActionResult DetailCus(int id)
        {
            var data = new Repositories().GetCusById(id);
            return View(data);
        }
        #endregion
        #region Delivery
        public ActionResult Delivery()
        {
            var data = new Repositories().GetDeliveries();
            return View(data);
        }

        public ActionResult CreateDeli(Delivery delivery)
        {
            if (delivery != null)
            {
                new Repositories().CreateDeli(delivery);
                return RedirectToAction("Delivery");
            }
            return RedirectToAction("Delivery");
        }

        public ActionResult EditDeli(int id)
        {
            var data = new Repositories().GetDeliveryById(id);
            return View(data);
        }

        public ActionResult UpdateDeli(Delivery delivery)
        {
            if (delivery != null)
            {
                new Repositories().UpdateDeli(delivery);
                return RedirectToAction("Delivery");
            }
            return RedirectToAction("Delivery");
        }

        public ActionResult DeleteDeli(int id)
        {
            new Repositories().DeleteDeli(id);
            return RedirectToAction("Delivery");
        }

        #endregion
        #region Order
        public ActionResult Order()
        {
            var data = new Repositories().GetOrders();
            return View(data);
        }

        public ActionResult ViewCreateOrder()
        {
            ViewBag.GetCus = new Repositories().GetCustomers();
            ViewBag.GetLaundry = new Repositories().GetLaundryTypes();
            return View();
        }

        public ActionResult CreateOrder(Order order)
        {
            if (order != null)
            {

                int num = new Random().Next(10000, 99990);
                order.idCode = num.ToString();
                new Repositories().CreateOrder(order);
                return RedirectToAction("DetailOrder", new { id = order.id });
            }
            return RedirectToAction("ViewCreateOrder");
        }

        public ActionResult EditOrder(int id)
        {
            ViewBag.GetCus = new Repositories().GetCustomers();
            ViewBag.GetLaundry = new Repositories().GetLaundryTypes();
            var data = new Repositories().GetOrderById(id);
            return View(data);
        }

        public ActionResult UpdateOrder(Order order)
        {
            if (order != null)
            {
                new Repositories().UpdateOrder(order);
                return RedirectToAction("DetailOrder", new { id = order.id });
            }
            return RedirectToAction("EditOrder", new { id = order.id });
        }

        public ActionResult DeleteOrder(int id)
        {
            new Repositories().DeleteOrder(id);
            return RedirectToAction("Order");
        }

        public ActionResult DetailOrder(int id)
        {
            var data = new Repositories().GetOrderById(id);
            return View(data);
        }

        #endregion
        #region Bill
        public ActionResult Bill()
        {
            var data = new Repositories().GetBills();
            return View(data);
        }

        public ActionResult ViewCreateBill()
        {
            return View();
        }

        public ActionResult CreateBill(Bill bill)
        {
            if (bill != null)
            {
                bill.dateCreate = DateTime.Now.ToString();
                new Repositories().CreateBill(bill);
                return RedirectToAction("Bill");
            }
            return RedirectToAction("ViewCreateBill");
        }

        public ActionResult DetailBill(int id)
        {
            var data = new Repositories().GetBillById(id);
            return View(data);
        }
        #endregion

    }
}