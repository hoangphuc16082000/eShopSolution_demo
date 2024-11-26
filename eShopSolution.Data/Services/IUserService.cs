using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.Data;

namespace eShopSolution.Data.Services
{
    public interface IUserService
    {
        Task<bool> Authencate(LoginRequest request);
        Task<bool> Authencate(RegisterRequest request);
    }
}