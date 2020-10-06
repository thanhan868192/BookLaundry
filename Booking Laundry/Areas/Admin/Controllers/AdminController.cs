using Booking_Laundry.Models;
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

        public ActionResult CreateLaundry()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult UpdateLaundry()
        {
            return View();
        }

        public ActionResult DeleteLaundry()
        {
            return View();
        }

        public ActionResult Detail()
        {
            return View();
        }

        #endregion

    }
}