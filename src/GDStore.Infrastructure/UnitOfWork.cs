using GDStore.Application.Interfaces;
using GDStore.Application.Interfaces.Repositories;
using GDStore.Infrastructure.Persistence;
using GDStore.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GDStore.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GDStoreDbContext _context;
        private IBrandRepository _brandRepository;
        private ICategoryRepository _categoryRepository;
        public IBrandRepository Brands => _brandRepository ?? (_brandRepository = new BrandRepository(_context));

        public ICategoryRepository Categories => _categoryRepository ?? (_categoryRepository = new CategoryRepository(_context));

        public UnitOfWork(GDStoreDbContext context)
        {
            _context = context;
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<int> SaveChangeAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
