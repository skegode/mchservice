using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CemesWebService.Models
{

    public class GurantorDetail
    {
        public GurantorDetail(string json)
        {

            JToken outer = JToken.Parse(json);
            JObject jObject = JObject.Parse(json);
            JToken jUser = jObject["gurantorDetails"];

            JObject inner = outer["gurantorDetails"].Value<JObject>();

            phone = (string)jUser["phone"];
            customerphone = (string)jUser["customerphone"];
            YearOfPurchase = (string)jUser["yearOfPurchase"];
            securityModel = (string)jUser["securityModel"];
            securitySerialNo = (string)jUser["securitySerialNo"];
            securityMarketValue = (string)jUser["securityMarketValue"];
            classid = (string)jUser["classid"];
            colateralsubclassid = (string)jUser["colateralsubclassid"];
            colateralconditionid = (string)jUser["colateralconditionid"];
            colaterallocationid = (string)jUser["colaterallocationid"];
            Firstname = (string)jUser["firstname"];
            Othernames = (string)jUser["othernames"];
            MobileNo = (string)jUser["mobileNo"];
            idno = (string)inner["idno"];
            sectype = (string)jUser["sectype"];
            secholder = (int)jUser["secholder"];
            secvalidity = (int)jUser["secvalidity"];
            selfie = (string)jUser["selfie"];
            idfront = (string)jUser["idfront"];
            idback = (string)jUser["idback"];
          

        }
        public string phone { get; set; }
        public string customerphone { get; set; }
        public string YearOfPurchase { get; set; }
        public string securityModel { get; set; }
        public string securitySerialNo { get; set; }
        public string securityMarketValue { get; set; }
        public string classid { get; set; }
        public string colateralsubclassid { get; set; }
        public string colateralconditionid { get; set; }
        public string colaterallocationid { get; set; }
        public string Firstname { get; set; }
        public string Othernames { get; set; }
        public string MobileNo { get; set; }
        public string idno { get; set; }
        public string sectype { get; set; }
        public int secholder { get; set; }
        public int secvalidity { get; set; }
        public string selfie { get; set; }
        public string idfront { get; set; }
        public string idback { get; set; }
    }

    public class GuarantorsRoot
    {
        public List<GRoot> gurantorDetails { get; set; }
    }
    public class GRoot
    {
        public string phone { get; set; }
        public string customerphone { get; set; }
        public string YearOfPurchase { get; set; }
        public string securityModel { get; set; }
        public string securitySerialNo { get; set; }
        public string securityMarketValue { get; set; }
        public string classid { get; set; }
        public string colateralsubclassid { get; set; }
        public string colateralconditionid { get; set; }
        public string colaterallocationid { get; set; }
        public string Firstname { get; set; }
        public string Othernames { get; set; }
        public string MobileNo { get; set; }
        public string idno { get; set; }
        public string sectype { get; set; }
        public int secholder { get; set; }
        public int secvalidity { get; set; }
        public string selfie { get; set; }
        public string idfront { get; set; }
        public string idback { get; set; }

    }

}
