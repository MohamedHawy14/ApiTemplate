using BrainHope.Services.DTO.Authentication.SingUp;
using CleanArchitecture.DataAccess.Models;
using CleanArchitecture.Services.DTOs.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Services.Interfaces
{
    public interface IAuthService
    {
        Task<ApiResponse<TokenType>> RegisterUserAsync(RegisterUser registerUser);

        Task<ApiResponse<LoginResponse>> GetJwtTokenAsync(ApplicationUser user);
    }
}
