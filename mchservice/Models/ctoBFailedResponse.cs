using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CemesWebService.Models
{
    public class ctoBFailedResponse
    {

        public string requestId { get; set; }
        public string errorCode { get; set; }
        public string errorMessage { get; set; }
    }
}
