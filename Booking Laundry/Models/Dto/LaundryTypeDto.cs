using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Booking_Laundry.Models.Dto
{
    public class LaundryTypeDto
    {
        public int id { get; set; }
        public string laundryName { get; set; }
        public string price { get; set; }
        public string init { get; set; }
        public string status { get; set; }

        public List<OrderDto> OrderDtos { get; set; }
    }
}