using System;
using System.Collections.Generic;

namespace BlazorApp5.Model
{
    public partial class Cart
    {
        public DateTime? DatePaid { get; set; }
        public double TotalCost { get; set; }
        public bool IsPaid { get; set; }
        public int Id { get; set; }
        public string UserId { get; set; }
    }
}
