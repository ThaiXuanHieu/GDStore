﻿using GDStore.Application.Common;
using GDStore.ViewModel.Categories;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
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
        public async Task<bool> Add(CategoryCreateRequest request)
        {
            _client.BaseAddress = new Uri(_config[Constants.AppSettings.BaseAddress]);

            var requestContent = new MultipartFormDataContent();
            requestContent.Add(new StringContent(request.Name.ToString()), "name");
            requestContent.Add(new StringContent(request.Description.ToString()), "description");

            var response = await _client.PostAsync($"/api/categories/", requestContent);
            return response.IsSuccessStatusCode;
        }

        public async Task<CategoryVm> Get(int id)
        {
            return await GetAsync<CategoryVm>("/api/categories/"+id);
        }

        public async Task<bool> Update(CategoryUpdateRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PutAsync("/api/categories/"+request.Id, httpContent);
            return response.IsSuccessStatusCode;
        }
    }
}
