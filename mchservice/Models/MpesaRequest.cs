using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CemesWebService.Models
{
    public class MpesaRequest
    {
        [JsonProperty("InitiatorName")]
        public string InitiatorName { get; set; }

        [JsonProperty("SecurityCredential")]
        public string SecurityCredential { get; set; }
        [JsonProperty("CommandID")]
        public string CommandID { get; set; }

        [JsonProperty("Amount")]
        public string Amount { get; set; }

        [JsonProperty("PartyA")]
        public string PartyA { get; set; }

        [JsonProperty("PartyB")]
        public string PartyB { get; set; }

        [JsonProperty("Remarks")]
        public string Remarks { get; set; }

        [JsonProperty("QueueTimeOutURL")]

        public string QueueTimeOutURL { get; set; }

        [JsonProperty("ResultURL")]
        public string ResultURL { get; set; }

        [JsonProperty("Occassion")]
        public string Occassion { get; set; }
    }
}
