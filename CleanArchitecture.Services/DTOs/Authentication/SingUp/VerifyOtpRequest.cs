using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainHope.Services.DTO.Authentication.SingUp
{
    public class VerifyOtpRequest
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Otp { get; set; }
    }

}
