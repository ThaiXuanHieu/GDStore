using GDStore.Domain.Entities;
using GDStore.Infrastructure.Persistence;
using GDStore.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GDStore.Infrastructure.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(GDStoreDbContext context) : base(context)
        {
        }
    }
}
