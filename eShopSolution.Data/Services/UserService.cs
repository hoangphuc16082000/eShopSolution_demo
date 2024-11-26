using System.Collections.Generic;
using System.Linq;
using eShopSolution.Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace eShopSolution.Data.Services
{
    public class UserService : IUserService
    {
        public UserService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager) {
            
        }

        public Task<bool> Authencate(Microsoft.AspNetCore.Identity.Data.LoginRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Authencate(Microsoft.AspNetCore.Identity.Data.RegisterRequest request)
        {
            throw new NotImplementedException();
        }
    }

    public class AppUser
    {
    }
}
