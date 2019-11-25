using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.ComponentModel;
using Newtonsoft.Json.Linq;

namespace CemesWebService.Models
{

    public class ResultParameter
    {
        public string Key { get; set; }
        public string Value { get; set; }

    }
    public class ResultParameters
    {
        [Setting, DefaultValue(default(List<string>))]
        public List<ResultParameter> ResultParameter { get; set; } = null;

    }

    public class ReferenceItem
    {
        public string Key { get; set; } = "noresponse";
        public string Value { get; set; } = "noresponse";

    }
    public class ReferenceData
    {
        public ReferenceItem ReferenceItem { get; set; }

    }
    public class Result
    {
        public int ResultType { get; set; } = 0;
        public int ResultCode { get; set; } = 0;
        public string ResultDesc { get; set; } = "noresponse";
        public string OriginatorConversationID { get; set; } = "noresponse";
        public string ConversationID { get; set; } = "noresponse";
        public string TransactionID { get; set; } = "noresponse";



        public ResultParameters ResultParameters { get; set; }
        public ReferenceData ReferenceData { get; set; }

    }
    public class RootObject
    {
        public Result Result { get; set; }

    }
    public class C2BProcessing
    {


            /// <summary>
            ///
            /// </summary>
            public string TransactionType { get; set; }
            /// <summary>
            ///
            /// </summary>
            public string TransID { get; set; }
            /// <summary>
            ///
            /// </summary>
            public string TransTime { get; set; }
            /// <summary>
            ///
            /// </summary>
            public string TransAmount { get; set; }
            /// <summary>
            ///
            /// </summary>
            public string BusinessShortCode { get; set; }
            /// <summary>
            ///
            /// </summary>
            public string BillRefNumber { get; set; }
            /// <summary>
            ///
            /// </summary>
            public string InvoiceNumber { get; set; }
            /// <summary>
            ///
            /// </summary>
            public string OrgAccountBalance { get; set; }
            /// <summary>
            ///
            /// </summary>
            public string ThirdPartyTransID { get; set; }
            /// <summary>
            ///
            /// </summary>
            public string MSISDN { get; set; }
            /// <summary>
            ///
            /// </summary>
            public string FirstName { get; set; }
            /// <summary>
            ///
            /// </summary>
            public string MiddleName { get; set; }
            /// <summary>
            ///
            /// </summary>
            public string LastName { get; set; }

    }


    public class Custdetail
    {
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
        public string idfront { get; set; }
        public string idback { get; set; }
        public string industryid { get; set; }
        public string MonthofEst { get; set; }
    }
   
 

    public class Root
    {
        public List<Custdetail> Custdetails { get; set; }
    }
    
}