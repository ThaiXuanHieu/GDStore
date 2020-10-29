using GDStore.Infrastructure.FileStorage;
using GDStore.Infrastructure.Persistence;
using GDStore.Infrastructure.Repositories;
using GDStore.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GDStore.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<GDStoreDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(GDStoreDbContext).Assembly.FullName)));

            services.AddTransient<IStorageService, FileStorageService>();

            // Repositories
            services.AddTransient(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddTransient<IBrandRepository, BrandRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();

            services.AddTransient<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
