using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreditInfo.Models
{
    public class CreditInfoResponse
    {
        public string Token { get; set; }
        public string Description { get; set; }
        public string FaultCode { get; set; }


    }

    public class CreditInfoAdvise
    {
        public string RecommendedDecision { get; set; }
        public string BrokenRules { get; set; }
        public string CreditLimit { get; set; }
        public string SubjectIDNumber { get; set; }
        public string RequestDate { get; set; }
        public string ReferenceNumber { get; set; }


        public string FullName { get; set; }
        public string DateOfBirth { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string EmploymentStatus { get; set; }



        public string Result { get; set; }
        public string Description { get; set; }
        public string Id { get; set; }



        public string CIPScore { get; set; }
        public string CIPRiskGrade { get; set; }
        public string MobileScore { get; set; }
        public string MobileScoreRiskGrade { get; set; }
        public string Conclusion { get; set; }




        public string TotalLast7Days { get; set; }
        public string TotalLast1Month { get; set; }
        public string NonBankingLast1Month { get; set; }



        public string Positive { get; set; }
        public string Negative { get; set; }
        public string Balance { get; set; }
        public string BalanceAtRisk { get; set; }


        public string CurrentNonBanking { get; set; }
        public string TotalCurrentPastDue { get; set; }
        public string TotalCurrentDaysPastDue { get; set; }
        public string MonthsWithoutArrearsLast12Months { get; set; }
        public string TotalMonthsWithHistoryLast12Months { get; set; }
        public string PercMonthsWithoutArrearsLast12Months { get; set; }


        public string TotalMonthlyPayment { get; set; }
        public string ClosedContracts { get; set; }
        public string NationalId { get; set; }
        public string Date { get; set; }
        public string Decision { get; set; }
        public string Found { get; set; }
        public string NbrokenRules { get; set; }

        public string MobileGrade { get; set; }

        public string CIPGrade { get; set; }
        public string AllContacts { get; set; }
        public string LimitChanged { get; set; }
        public string MatchPreviousEligible { get; set; }
        public string NRepaidLoans { get; set; }
        public string CreditRisk { get; set; }
        public string SCR1Result { get; set; }
        public string SCR1Parameter { get; set; }
        public string SCR1Value { get; set; }
        public string SCR3Result { get; set; }
        public string SCR3Parameter { get; set; }
        public string SCR3Value { get; set; }
        public string INQ2Result { get; set; }
        public string INQ2Parameter { get; set; }
        public string INQ2Value { get; set; }
        public string RSK0Result { get; set; }
        public string RSK2Result { get; set; }
        public string RSK2Parameter { get; set; }
        public string RSK3Result { get; set; }
        public string RSK3Parameter { get; set; }
        public string RSK4Result { get; set; }
        public string RSK4Parameter { get; set; }
        public string RSK6Result { get; set; }
        public string RSK6Parameter { get; set; }
        public string RSK6Value { get; set; }
        public string RSK7Result { get; set; }
        public string RSK7Parameter { get; set; }
        public string RSK8Result { get; set; }
        public string RSK8Parameter { get; set; }
        public string RSK8Value { get; set; }
        public string RSK11Result { get; set; }
        public string RSK11Parameter { get; set; }
        public string CST12Result { get; set; }
        public string CST1Result { get; set; }
        public string CST2Result { get; set; }
        public string CST3Result { get; set; }
        public string CST4Result { get; set; }
        public string CST5Result { get; set; }
        public string ExistingCustomer { get; set; }
        public string MobilePhone { get; set; }
        public string AgeOfBusiness { get; set; }
        public string SalesTurnover { get; set; }
        public string NDaysInRollover { get; set; }
        public string NDeclinedApplicationsL3m { get; set; }
        public string RepaymentScore { get; set; }
        public string DateOfLastLimitChange { get; set; }



    }








}