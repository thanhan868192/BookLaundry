using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Booking_Laundry.Models.Dto
{
    public class OrderDto
    {
        public int id { get; set; }
        public string idCode { get; set; }
        public int? customerId { get; set; }
        public int? laundryTypeId { get; set; }
        public string amountUnit { get; set; }
        public string orderType { get; set; }
        public string description { get; set; }
        public string totalPayment { get; set; }
        public string status { get; set; }
        public int? idDelivery { get; set; }

        public  CustomerDto CustomerDto { get; set; }
        public  DeliveryDto DeliveryDto { get; set; }
        public  LaundryTypeDto LaundryTypeDto { get; set; }
    }
}