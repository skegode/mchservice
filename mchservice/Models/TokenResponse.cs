using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CemesWebService.Models
{
    public class TokenResponse
    {
        public string access_token { get; set; }
        public string expires_in { get; set; }
    }
}
