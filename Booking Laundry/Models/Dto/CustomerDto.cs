using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Booking_Laundry.Models.Dto
{
    public class CustomerDto
    {
        public int id { get; set; }
        public string idCode { get; set; }
        public string idCard { get; set; }
        public string fullName { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }
        public string gender { get; set; }
        public string status { get; set; }
        public List<OrderDto> OrderDtos { get; set; }
    }
}