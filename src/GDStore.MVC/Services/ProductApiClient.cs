using GDStore.ViewModel.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace GDStore.MVC.Services
{
    public class ProductApiClient : IProductApiClient
    {
        private readonly HttpClient _client;
        public ProductApiClient(HttpClient client)
        {
            _client = client;
        }
        public async Task Add(ProductCreateRequest request)
        {
            var requestContent = new MultipartFormDataContent();
            var response = await _client.PostAsync($"/api/products/", requestContent);
        }

        public async Task<IEnumerable<ProductVm>> GetAll()
        {
            var response = await _client.GetAsync($"/api/products");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IEnumerable<ProductVm>>();
        }
    }
}
