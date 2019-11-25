using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreditInfo.Models
{
    

    public class CreditAdvisoryPlan
    {
        [JsonProperty("RecommendedDecision")]
        public string RecommendedDecision { get; set; }
        [JsonProperty("BrokenRules")]
        public string BrokenRules { get; set; }
        [JsonProperty("CreditLimit")]
        public string CreditLimit { get; set; }
        [JsonProperty("SubjectIDNumber")]
        public string SubjectIDNumber { get; set; }
        [JsonProperty("RequestDate")]
        public string RequestDate { get; set; }
        [JsonProperty("ReferenceNumber")]
        public string ReferenceNumber { get; set; }
        [JsonProperty("FullName")]

        public string FullName { get; set; }
        [JsonProperty("DateOfBirth")]
        public string DateOfBirth { get; set; }
        [JsonProperty("Age")]
        public string Age { get; set; }
        [JsonProperty("Gender")]
        public string Gender { get; set; }
        [JsonProperty("MaritalStatus")]
        public string MaritalStatus { get; set; }
        [JsonProperty("EmploymentStatus")]
        public string EmploymentStatus { get; set; }

        [JsonProperty("Result")]

        public string Result { get; set; }
        [JsonProperty("Description")]
        public string Description { get; set; }
        [JsonProperty("Id")]
        public string Id { get; set; }


        [JsonProperty("CIPScore")]
        public string CIPScore { get; set; }
        [JsonProperty("CIPRiskGrade")]
        public string CIPRiskGrade { get; set; }
        [JsonProperty("MobileScore")]
        public string MobileScore { get; set; }
        [JsonProperty("MobileScoreRiskGrade")]
        public string MobileScoreRiskGrade { get; set; }
        [JsonProperty("Conclusion")]
        public string Conclusion { get; set; }


        [JsonProperty("TotalLast7Days")]

        public string TotalLast7Days { get; set; }
        [JsonProperty("TotalLast1Month")]
        public string TotalLast1Month { get; set; }
        [JsonProperty("NonBankingLast1Month")]
        public string NonBankingLast1Month { get; set; }
        [JsonProperty("Positive")]



        public string Positive { get; set; }
        [JsonProperty("Negative")]
        public string Negative { get; set; }
        [JsonProperty("Balance")]
        public string Balance { get; set; }
        [JsonProperty("BalanceAtRisk")]
        public string BalanceAtRisk { get; set; }

        [JsonProperty("CurrentNonBanking")]
        public string CurrentNonBanking { get; set; }
        [JsonProperty("TotalCurrentPastDue")]
        public string TotalCurrentPastDue { get; set; }
        [JsonProperty("TotalCurrentDaysPastDue")]
        public string TotalCurrentDaysPastDue { get; set; }
        [JsonProperty("MonthsWithoutArrearsLast12Months")]
        public string MonthsWithoutArrearsLast12Months { get; set; }
        [JsonProperty("TotalMonthsWithHistoryLast12Months")]
        public string TotalMonthsWithHistoryLast12Months { get; set; }
        [JsonProperty("PercMonthsWithoutArrearsLast12Months")]
        public string PercMonthsWithoutArrearsLast12Months { get; set; }

        [JsonProperty("TotalMonthlyPayment")]
        public string TotalMonthlyPayment { get; set; }
        [JsonProperty("ClosedContracts")]
        public string ClosedContracts { get; set; }
        [JsonProperty("NationalId")]
        public string NationalId { get; set; }
        [JsonProperty("Date")]
        public string Date { get; set; }
        [JsonProperty("Decision")]
        public string Decision { get; set; }
        [JsonProperty("Found")]
        public string Found { get; set; }
        [JsonProperty("NbrokenRules")]
        public string NbrokenRules { get; set; }
        [JsonProperty("MobileGrade")]

        public string MobileGrade { get; set; }
        [JsonProperty("CIPGrade")]

        public string CIPGrade { get; set; }
        [JsonProperty("AllContacts")]
        public string AllContacts { get; set; }
        [JsonProperty("LimitChanged")]
        public string LimitChanged { get; set; }
        [JsonProperty("MatchPreviousEligible")]
        public string MatchPreviousEligible { get; set; }
        [JsonProperty("NRepaidLoans")]
        public string NRepaidLoans { get; set; }
        [JsonProperty("CreditRisk")]
        public string CreditRisk { get; set; }
        [JsonProperty("SCR1Result")]
        public string SCR1Result { get; set; }
        [JsonProperty("SCR1Parameter")]
        public string SCR1Parameter { get; set; }
        [JsonProperty("SCR1Value")]
        public string SCR1Value { get; set; }
        [JsonProperty("SCR3Result")]
        public string SCR3Result { get; set; }
        [JsonProperty("SCR3Parameter")]
        public string SCR3Parameter { get; set; }
        [JsonProperty("SCR3Value")]
        public string SCR3Value { get; set; }
        [JsonProperty("INQ2Result")]
        public string INQ2Result { get; set; }
        [JsonProperty("INQ2Parameter")]
        public string INQ2Parameter { get; set; }
        [JsonProperty("INQ2Value")]
        public string INQ2Value { get; set; }
        [JsonProperty("RSK0Result")]
        public string RSK0Result { get; set; }
        [JsonProperty("RSK2Result")]
        public string RSK2Result { get; set; }
        [JsonProperty("RSK2Parameter")]
        public string RSK2Parameter { get; set; }
        [JsonProperty("RSK3Result")]
        public string RSK3Result { get; set; }
        [JsonProperty("RSK3Parameter")]
        public string RSK3Parameter { get; set; }
        [JsonProperty("RSK4Result")]
        public string RSK4Result { get; set; }
        [JsonProperty("RSK4Parameter")]
        public string RSK4Parameter { get; set; }
        [JsonProperty("RSK6Result")]
        public string RSK6Result { get; set; }
        [JsonProperty("RSK6Parameter")]
        public string RSK6Parameter { get; set; }
        [JsonProperty("RSK6Value")]
        public string RSK6Value { get; set; }
        [JsonProperty("RSK7Result")]
        public string RSK7Result { get; set; }
        [JsonProperty("RSK7Parameter")]
        public string RSK7Parameter { get; set; }
        [JsonProperty("RSK8Result")]
        public string RSK8Result { get; set; }
        [JsonProperty("RSK8Parameter")]
        public string RSK8Parameter { get; set; }
        [JsonProperty("RSK8Value")]
        public string RSK8Value { get; set; }
        [JsonProperty("RSK11Result")]
        public string RSK11Result { get; set; }
        [JsonProperty("RSK11Parameter")]
        public string RSK11Parameter { get; set; }
        [JsonProperty("CST12Result")]
        public string CST12Result { get; set; }
        [JsonProperty("CST1Result")]
        public string CST1Result { get; set; }
        [JsonProperty("CST2Result")]
        public string CST2Result { get; set; }
        [JsonProperty("CST3Result")]
        public string CST3Result { get; set; }
        [JsonProperty("CST4Result")]
        public string CST4Result { get; set; }
        [JsonProperty("CST5Result")]
        public string CST5Result { get; set; }
        [JsonProperty("ExistingCustomer")]
        public string ExistingCustomer { get; set; }
        [JsonProperty("MobilePhone")]
        public string MobilePhone { get; set; }
        [JsonProperty("AgeOfBusiness")]
        public string AgeOfBusiness { get; set; }
        [JsonProperty("SalesTurnover")]
        public string SalesTurnover { get; set; }
        [JsonProperty("NDaysInRollover")]
        public string NDaysInRollover { get; set; }
        [JsonProperty("NDeclinedApplicationsL3m")]
        public string NDeclinedApplicationsL3m { get; set; }
        [JsonProperty("RepaymentScore")]
        public string RepaymentScore { get; set; }
        [JsonProperty("DateOfLastLimitChange")]
        public string DateOfLastLimitChange { get; set; }
        [JsonProperty("FaultCode")]
        public string FaultCode { get; set; }

    }








}