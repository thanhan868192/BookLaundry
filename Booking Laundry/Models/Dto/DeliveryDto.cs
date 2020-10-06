using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Booking_Laundry.Models.Dto
{
    public class DeliveryDto
    {
        public int id { get; set; }
        public string name { get; set; }

        public List<OrderDto> OrderDtos { get; set; }
    }
}