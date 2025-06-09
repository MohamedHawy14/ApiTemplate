using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Services.DTOs.Responses
{
    public class Response
    {
        public string? Status { get; set; }
        public string? Message { get; set; }

        public bool IsSuccess { get; set; }
    }
}
