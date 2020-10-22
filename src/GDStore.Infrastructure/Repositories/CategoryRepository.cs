using GDStore.Application.Interfaces.Repositories;
using GDStore.Domain.Entities;
using GDStore.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace GDStore.Infrastructure.Repositories
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(GDStoreDbContext context) : base(context)
        {

        }
    }
}
