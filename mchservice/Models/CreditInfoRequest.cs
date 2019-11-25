using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CemesWebService.Models
{
    public class CreditInfoRequest
    {

        [JsonProperty("NationalId")]
        public string NationalId { get; set; }
        [JsonProperty("ExistingCustomer")]
        public string ExistingCustomer { get; set; }
        [JsonProperty("MobilePhone")]
        public string MobilePhone { get; set; }
        [JsonProperty("AgeOfBusiness")]
        public string AgeOfBusiness { get; set; }
        [JsonProperty("SalesTurnover")]
        public string SalesTurnover { get; set; }
        [JsonProperty("NDeclinedApplicationsL3m")]
        public string NDeclinedApplicationsL3m { get; set; }
        [JsonProperty("RepaymentScore")]
        public string RepaymentScore { get; set; }
        [JsonProperty("DateOfLastLimitChange")]
        public string DateOfLastLimitChange { get; set; }
        [JsonProperty("Consent")]
        public string Consent { get; set; }

        [JsonProperty("NDaysInRollover")]
        public string NDaysInRollover { get; set; }

    }
}
