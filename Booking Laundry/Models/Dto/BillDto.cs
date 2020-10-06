using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Booking_Laundry.Models.Dto
{
    public class BillDto
    {
        public int id { get; set; }
        public string idCode { get; set; }
        public string dateCreate { get; set; }
        public string totalExpenses { get; set; }
        public string status { get; set; }
    }
}