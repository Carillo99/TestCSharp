using System;
using System.Collections.Generic;
using System.Text;

namespace Providers.Domain.Entities.GlobalError
{
    public class ErrorDetails
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
    }
}
