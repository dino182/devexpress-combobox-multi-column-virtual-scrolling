using System;
using System.Collections.Generic;

#nullable disable

namespace BlazorApp.Shared.Models
{
    public partial class OrderDetail
    {
        public string Id { get; set; }
        public long OrderId { get; set; }
        public long ProductId { get; set; }
        public byte[] UnitPrice { get; set; }
        public long Quantity { get; set; }
        public double Discount { get; set; }
    }
}
