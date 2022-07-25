using System;
using System.Collections.Generic;

namespace BlazorApp5.Model
{
    public partial class Item
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateOfEntry { get; set; }
        public double Price { get; set; }
        public string? Image { get; set; }

        public virtual Product? Product { get; set; }
    }
}
