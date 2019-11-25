using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CemesWebService.Models
{
    public class passwordchangeclass
    {
        public string phone { get; set; }
        public string password { get; set; }

        public string otp { get; set; }
        public string imei { get; set; }
        public string manufacturer { get; set; }
        public string model { get; set; }

    }
}
