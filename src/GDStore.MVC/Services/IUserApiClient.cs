﻿using GDStore.Application.Models;
using GDStore.ViewModel.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GDStore.MVC.Services
{
    public interface IUserApiClient
    {
        Task<ApiResult<string>> Login(LoginRequest request);
    }
}
