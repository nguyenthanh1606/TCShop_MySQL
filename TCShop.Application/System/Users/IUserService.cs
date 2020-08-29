using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TCShop.ViewModels.System.Users;

namespace TCShop.Application.System.Users
{
    public interface IUserService
    {
        Task<string> Authencate(LoginRequest request);
        Task<bool> Register(RegisterRequest request);
    }
}
