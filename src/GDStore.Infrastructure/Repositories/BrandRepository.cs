using GDStore.Application.Interfaces.Repositories;
using GDStore.Domain.Entities;
using GDStore.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace GDStore.Infrastructure.Repositories
{
    public class BrandRepository : RepositoryBase<Brand>, IBrandRepository
    {
        public BrandRepository(GDStoreDbContext context) : base(context)
        {

        }
    }
}
