﻿namespace NetCoreAPI.Entities
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public string ProductSlug { get; set; }
        public ICollection<Image> Images { get; set; }
    }
}

