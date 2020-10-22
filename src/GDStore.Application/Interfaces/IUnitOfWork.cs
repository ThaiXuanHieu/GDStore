using GDStore.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GDStore.Application.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IBrandRepository Brands { get; }
        ICategoryRepository Categories { get; }
        Task<int> SaveChangeAsync(CancellationToken cancellationToken);
    }
}
