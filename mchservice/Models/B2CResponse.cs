using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CemesWebService.Models
{
    public class B2CResponse
    {
        public string ConversationId { get; set; }
        public string OriginatorConversationId { get; set; }
        public string ResponseCode { get; set; }
        public string ResponseDescription { get; set; }
    }
}
