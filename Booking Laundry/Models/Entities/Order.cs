//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Booking_Laundry.Models.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int id { get; set; }
        public string idCode { get; set; }
        public Nullable<int> customerId { get; set; }
        public Nullable<int> laundryTypeId { get; set; }
        public Nullable<int> idDelivery { get; set; }
        public string amountUnit { get; set; }
        public string description { get; set; }
        public string totalPayment { get; set; }
        public string status { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Delivery Delivery { get; set; }
        public virtual LaundryType LaundryType { get; set; }
    }
}
