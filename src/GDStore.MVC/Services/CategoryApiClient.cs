using GDStore.Application.Common;
using GDStore.ViewModel.Categories;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GDStore.MVC.Services
{
    public class CategoryApiClient : BaseApiClient, ICategoryApiClient
    {
        private readonly HttpClient _client;
        private readonly IConfiguration _config;
        public CategoryApiClient(HttpClient client, IConfiguration config): base(client, config)
        {
            _client = client;
            _config = config;
        }
        public async Task<IEnumerable<CategoryVm>> GetAll()
        {
            return await GetListAsync<CategoryVm>("/api/categories");
        }
    }
}
