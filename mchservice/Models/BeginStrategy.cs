using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CreditInfo.Models
{
    public class BeginStrategy
    {
        private static BeginStrategy _request;
        public string _xml = "";
        string sConnectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;

        public static BeginStrategy getInstance()
        {
            if (BeginStrategy._request != null)
                return BeginStrategy._request;
            BeginStrategy._request = new BeginStrategy();
            return BeginStrategy._request;
        }
        //DateOfLastLimitChange
        public async Task<string> CreateSoapEnvelope(string NationalId, string ExistingCustomer, string MobilePhone, string AgeOfBusiness, string SalesTurnover, string NDaysInRollover, string NDeclinedApplicationsL3m, string RepaymentScore, string DateOfLastLimitChange)
        {
            _xml = "<?xml version =\"1.0\" encoding=\"utf-8\"?>\r\n<soapenv:Envelope xmlns:soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:mul=\"http://creditinfo.com/schemas/2012/09/MultiConnector\" xmlns:req=\"http://creditinfo.com/schemas/2012/09/MultiConnector/Messages/Request\">\r\n<soapenv:Header>\r\n<wsse:Security soapenv:mustUnderstand=\"1\" xmlns:wsse=\"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd\">\r\n<wsse:UsernameToken wsu:Id=\"UsernameToken-1\" xmlns:wsu=\"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd\">\r\n<wsse:Username>cemes</wsse:Username>\r\n<wsse:Password Type=\"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-username-token-profile-1.0#PasswordText\">Cemes1</wsse:Password>\r\n</wsse:UsernameToken></wsse:Security>\r\n</soapenv:Header>\r\n<soapenv:Body>\r\n<mul:BeginStrategy>\r\n<mul:request>\r\n<mul:RequestXml>\r\n<mul:RequestXml>\r\n<req:Strategy id=\"af7df4e2-2c2d-4401-b114-72668260d7c7\">\r\n<ConnectorRequest><NationalId>"+ NationalId + "</NationalId>\r\n</ConnectorRequest>\r\n<CustomFields>\r\n<ExistingCustomer> "+ ExistingCustomer + " </ExistingCustomer>\r\n<MobilePhone>"+ MobilePhone + "</MobilePhone>\r\n<AgeOfBusiness>"+ AgeOfBusiness + "</AgeOfBusiness>\r\n<SalesTurnover>"+ SalesTurnover + "</SalesTurnover>\r\n<NDaysInRollover>"+ NDaysInRollover + "</NDaysInRollover>\r\n<NDeclinedApplicationsL3m>"+ NDeclinedApplicationsL3m + "</NDeclinedApplicationsL3m>\r\n<RepaymentScore>"+ RepaymentScore + "</RepaymentScore>\r\n<DateOfLastLimitChange>"+ DateOfLastLimitChange + "</DateOfLastLimitChange>\r\n</CustomFields>\r\n<req:Consent> true </req:Consent>\r\n</req:Strategy>\r\n</mul:RequestXml>\r\n</mul:RequestXml>\r\n</mul:request>\r\n</mul:BeginStrategy> \r\n</soapenv:Body>\r\n</soapenv:Envelope>";

            return await (await BeginStrategy.PostXmlRequest("https://idmtest.creditinfo.co.ke/idm.svc", _xml)).Content.ReadAsStringAsync();
        }
        public static async Task<HttpResponseMessage> PostXmlRequest(
        string baseUrl,
        string xmlString)
        {
            StringContent stringContent = null;
            HttpResponseMessage httpResponseMessage;
            using (HttpClient httpClient = new HttpClient())
            {
                stringContent = new StringContent(xmlString, Encoding.UTF8, "text/xml");
                stringContent.Headers.Add("SOAPAction", "http://creditinfo.com/schemas/2012/09/MultiConnector/IdmService/BeginStrategy");
                httpResponseMessage = await httpClient.PostAsync(baseUrl, (HttpContent)stringContent);
            }
            return httpResponseMessage;
        }
        public async Task<string> CreateSoapEnvelopeEndStrat(string Token)
        {
            _xml = "<?xml version =\"1.0\" encoding=\"utf-8\"?>\r\n<soapenv:Envelope xmlns:soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:mul=\"http://creditinfo.com/schemas/2012/09/MultiConnector\" xmlns:req=\"http://creditinfo.com/schemas/2012/09/MultiConnector/Messages/Request\">\r\n<soapenv:Header>\r\n<wsse:Security soapenv:mustUnderstand=\"1\" xmlns:wsse=\"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd\">\r\n<wsse:UsernameToken wsu:Id=\"UsernameToken-1\" xmlns:wsu=\"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd\">\r\n<wsse:Username>cemes</wsse:Username>\r\n<wsse:Password Type=\"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-username-token-profile-1.0#PasswordText\">Cemes1</wsse:Password>\r\n</wsse:UsernameToken></wsse:Security>\r\n</soapenv:Header>\r\n<soapenv:Body>\r\n<mul:EndStrategy>\r\n<mul:request>\r\n<mul:Token>" + Token  + "</mul:Token>\r\n</mul:request>\r\n</mul:EndStrategy> \r\n</soapenv:Body>\r\n</soapenv:Envelope>";

            return await (await BeginStrategy.PostXmlRequestEndstrat("https://idmtest.creditinfo.co.ke/idm.svc", _xml)).Content.ReadAsStringAsync();
        }
        public static async Task<HttpResponseMessage> PostXmlRequestEndstrat(
          string baseUrl,
          string xmlString)
        {
            StringContent stringContent = null;
            HttpResponseMessage httpResponseMessage;
            using (HttpClient httpClient = new HttpClient())
            {
                stringContent = new StringContent(xmlString, Encoding.UTF8, "text/xml");
                stringContent.Headers.Add("SOAPAction", "http://creditinfo.com/schemas/2012/09/MultiConnector/IdmService/EndStrategy");
                httpResponseMessage = await httpClient.PostAsync(baseUrl, (HttpContent)stringContent);
            }
            return httpResponseMessage;
        }
        
       
    }
}
