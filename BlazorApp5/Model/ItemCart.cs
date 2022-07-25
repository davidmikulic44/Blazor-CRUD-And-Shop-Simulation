using System;
using System.Collections.Generic;

namespace BlazorApp5.Model
{
    public partial class ItemCart
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int CartId { get; set; }
        public int Quantity { get; set; }
    }
}
