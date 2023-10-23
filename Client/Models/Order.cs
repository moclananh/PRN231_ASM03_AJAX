using System;

namespace Client.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string MemberId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? RequireDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int Freight { get; set; }
    }
}
