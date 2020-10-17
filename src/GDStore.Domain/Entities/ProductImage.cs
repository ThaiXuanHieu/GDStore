using System;
using System.Collections.Generic;
using System.Text;

namespace GDStore.Domain.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public bool IsDefault { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int SortOrder { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
