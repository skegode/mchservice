using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CemesWebService.Models
{
    public class c2bUrlRequest
    {
        [JsonProperty("ShortCode")]
        public string ShortCode { get; set; }

        [JsonProperty("ResponseType")]
        public string ResponseType { get; set; }

        [JsonProperty("ConfirmationURL")]
        public string ConfirmationURL { get; set; }


        [JsonProperty("ValidationURL")]
        public string ValidationURL { get; set; }
    }
}
