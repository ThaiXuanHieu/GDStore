using GDStore.Domain.Entities;
using GDStore.Infrastructure.Persistence;
using GDStore.Infrastructure.Repositories.Interfaces;

namespace GDStore.Infrastructure.Repositories
{
    public class BrandRepository : RepositoryBase<Brand>, IBrandRepository
    {
        public BrandRepository(GDStoreDbContext context) : base(context)
        {

        }
    }
}
