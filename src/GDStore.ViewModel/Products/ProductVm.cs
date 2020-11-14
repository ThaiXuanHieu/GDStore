﻿using GDStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GDStore.ViewModel.Products
{
    public class ProductVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int Rating { get; set; }
        public List<string> ThumbnailImage { get; set; }
    }
}
