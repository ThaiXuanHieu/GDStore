using System;
using System.Collections.Generic;
using System.Text;

namespace GDStore.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public IList<ProductCategory> ProductCategories { get; set; } = new List<ProductCategory>();
    }
}
