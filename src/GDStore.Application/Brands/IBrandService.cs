using System.Collections;
using System.Threading.Tasks;

namespace GDStore.Application.Brands
{
    public interface IBrandService
    {
        Task<IEnumerable> GetBrands();
    }
}
