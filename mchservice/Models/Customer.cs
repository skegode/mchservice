using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CemesWebService.Models
{
    public class Customer
    {

        public Customer(string json)
        {

            JToken outer = JToken.Parse(json);
            JObject jObject = JObject.Parse(json);
            JToken jUser = jObject["custdetails"];

            JObject inner = outer["custdetails"].Value<JObject>();

            maritalstatus = (string)jUser["maritalstatus"];
            periodresiding = (string)jUser["periodresiding"];
            residencetype = (string)jUser["residencetype"];
            physicaladdress = (string)jUser["physicaladdress"];
            postalcode = (string)jUser["postalcode"];
            postaladdress = (string)jUser["postaladdress"];
            businessname = (string)jUser["businessname"];
            businesslocation = (string)jUser["businesslocation"];
            businesstypeid = (string)jUser["businesstypeid"];
            businesslandmark = (string)jUser["businesslandmark"];
            businessyearest = (string)jUser["businessyearest"];
            businessauthority = (string)jUser["businessauthority"];
            title = (string)jUser["title"];
            

            FirstName = (string)inner["firstName"];
            OtherNames = (string)jUser["otherNames"];
            Gender = (string)jUser["gender"];
            DOB = (string)jUser["dOB"];
            Mobile = (string)jUser["mobile"];
            Email = (string)jUser["email"];
            ID_PASS = (string)jUser["iD_PASS"];
            DEVICEID = (string)jUser["dEVICEID"];
            countyid = (string)jUser["countyid"];
            subcountyid = (string)jUser["subcountyid"];
            constituencyid = (string)jUser["constituencyid"];
            wardid = (string)jUser["wardid"];
            educationid = (string)jUser["educationid"];
            type = (string)jUser["type"];
            registeredby = (string)jUser["registeredby"];
            officerphone = (string)jUser["officerphone"];
            SELFIE_PHOTO = (string)jUser["sELFIE_PHOTO"];
            idback = (string)jUser["idback"];
            idfront = (string)jUser["idfront"];
            industryid= (string)jUser["industryid"];
            MonthofEst = (string)jUser["MonthofEst"];


        }

        public string maritalstatus { get; set; }
        public string periodresiding { get; set; }
        public string residencetype { get; set; }
        public string physicaladdress { get; set; }
        public string postalcode { get; set; }
        public string postaladdress { get; set; }
        public string businessname { get; set; }
        public string businesslocation { get; set; }
        public string businesstypeid { get; set; }
        public string businesslandmark { get; set; }
        public string businessyearest { get; set; }
        public string businessauthority { get; set; }
        public string title { get; set; }
        public string FirstName { get; set; }
        public string OtherNames { get; set; }
        public string Gender { get; set; }
        public string DOB { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string ID_PASS { get; set; }
        public string DEVICEID { get; set; }
        public string countyid { get; set; }
        public string subcountyid { get; set; }
        public string constituencyid { get; set; }
        public string wardid { get; set; }
        public string educationid { get; set; }
        public string type { get; set; }
        public string registeredby { get; set; }
        public string officerphone { get; set; }
        public string SELFIE_PHOTO { get; set; }
        public string idback { get; set; }
        public string idfront { get; set; }
        public string industryid { get; set; }
        public string MonthofEst { get; set; }
    }
}
