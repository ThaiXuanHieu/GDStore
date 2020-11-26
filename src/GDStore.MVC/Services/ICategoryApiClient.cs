using GDStore.ViewModel.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GDStore.MVC.Services
{
    public interface ICategoryApiClient
    {
        Task<IEnumerable<CategoryVm>> GetAll();
    }
}
