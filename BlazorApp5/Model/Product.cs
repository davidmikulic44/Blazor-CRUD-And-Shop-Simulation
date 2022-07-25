using System;
using System.Collections.Generic;

namespace BlazorApp5.Model
{
    public partial class Product
    {
        public Product()
        {
            Items = new HashSet<Item>();
        }

        public int Id { get; set; }
        public string ProductName { get; set; } = null!;
        public bool IsDeleted { get; set; }
        public string? ProductDescription { get; set; }
        public DateTime DateOfEntry { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}
