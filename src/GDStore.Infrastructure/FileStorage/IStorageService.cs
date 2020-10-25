using System.IO;
using System.Threading.Tasks;

namespace GDStore.Infrastructure.FileStorage
{
    public interface IStorageService
    {
        string GetFileUrl(string fileName);

        Task SaveFileAsync(Stream mediaBinaryStream, string fileName);

        Task DeleteFileAsync(string fileName);
    }
}
