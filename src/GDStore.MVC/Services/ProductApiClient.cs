using GDStore.Application.Common;
using GDStore.ViewModel.Products;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace GDStore.MVC.Services
{
    public class ProductApiClient : BaseApiClient, IProductApiClient
    {
        private readonly HttpClient _client;
        private readonly IConfiguration _config;
        public ProductApiClient(HttpClient client, IConfiguration config): base(client, config)
        {
            _client = client;
            _config = config;
        }
        public async Task<bool> Add(ProductCreateRequest request)
        {
            _client.BaseAddress = new Uri(_config[Constants.AppSettings.BaseAddress]);
            var requestContent = new MultipartFormDataContent();
            if (request.ThumbnailImage != null)
            {
                byte[] data;
                List<ByteArrayContent> bytes = new List<ByteArrayContent>();
                foreach (var item in request.ThumbnailImage)
                {
                    using (var br = new BinaryReader(item.OpenReadStream()))
                    {
                        data = br.ReadBytes((int)item.OpenReadStream().Length);
                        bytes.Add( new ByteArrayContent(data));
                        
                    }
                }
                var json = JsonConvert.SerializeObject(bytes);
                var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
                requestContent.Add(httpContent, "thumbnailImage");
            }

            requestContent.Add(new StringContent(request.Price.ToString()), "price");
            requestContent.Add(new StringContent(request.OriginalPrice.ToString()), "originalPrice");
            requestContent.Add(new StringContent(request.Name.ToString()), "name");
            requestContent.Add(new StringContent(request.Description.ToString()), "description");
            requestContent.Add(new StringContent(request.BrandId.ToString()), "brandId");
            requestContent.Add(new StringContent(request.CategoryIds.ToString()), "categoryIds");

            var response = await _client.PostAsync($"/api/products/", requestContent);
            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<ProductVm>> GetAll()
        {
            _client.BaseAddress = new Uri(_config[Constants.AppSettings.BaseAddress]);
            return await GetListAsync<ProductVm>("/api/products");
        }
    }
}
