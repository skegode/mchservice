using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreditInfo.Models
{
    public class BeginStrategyClass
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string NationalId { get; set; }
        public string ExistingCustomer { get; set; }
        public string MobilePhone { get; set; }
        public string AgeOfBusiness { get; set; }
        public string SalesTurnover { get; set; }
        public string NDaysInRollover { get; set; }
        public string NDeclinedApplicationsL3m { get; set; }
        public string RepaymentScore { get; set; }
        public string DateOfLastLimitChange { get; set; }
        public string Consent { get; set; }
        public string Token { get; set; }
    }
}