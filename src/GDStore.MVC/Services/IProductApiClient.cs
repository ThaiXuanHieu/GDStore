using GDStore.ViewModel.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GDStore.MVC.Services
{
    public interface IProductApiClient
    {
        Task<IEnumerable<ProductVm>> GetAll();
        Task Add(ProductCreateRequest request);
    }
}
