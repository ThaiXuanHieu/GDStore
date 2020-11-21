using GDStore.Application.Models;
using GDStore.ViewModel.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GDStore.Application.Users
{
    public interface IUserService
    {
        Task<ApiResult<string>> Login(LoginRequest request);
    }
}
