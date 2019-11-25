using CemesWebService.Models;
using CreditInfo.Models;
using Nancy.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace mchservice
{
    class Sabuni
    {
        public const string connectionString = "server=197.232.70.193,50003;" + "initial catalog=MICROCAP_HOLD;" + "user id=sa;" + "password=123456";
        SqlConnection con = new SqlConnection();
        //#region Credit Info Advisory
        //string soapEnvelope = "";
        //XmlDocument xmlDocument;
        //XmlDocument xmlDoc;
        //XmlDocument xmlDc;
        //string jsonText = "";
        //CreditAdvisoryPlan infoAdvise = new CreditAdvisoryPlan();
        //[Route("SabuniApi")]
        //[HttpPost]
        //public async Task<string> CreditInfoRequestAsync(string receivedjson)
        //{
        //    int pendingchecks = 0;

        //    //getting number of txn to be rolled over
        //    var countquery = "select count(userid) as count from customers where Creditinfochecked=0  ";
        //    SqlCommand cmdcount = new SqlCommand(countquery, con);

        //    con.ConnectionString = connectionString;
        //    con.Open();
        //    using (SqlDataReader read = cmdcount.ExecuteReader())
        //    {
        //        while (read.Read())
        //        {

        //            pendingchecks = Convert.ToInt32((read["count"]));
        //        }

        //        con.Close();


        //    }
        //    con.Close();
        //    int i;
        //    for (i = 0; i < pendingchecks; i++)
        //    {
        //        string NationalId = "";
        //        string ExistingCustomer = "True";
        //        string MobilePhone = "";
        //        int AgeOfBusiness =1;
        //        string SalesTurnover = "3000";
        //        string NDaysInRollover = "";
        //        string NDeclinedApplicationsL3m = "";
        //        string RepaymentScore = ""; string DateOfLastLimitChange = "";
        //        var fetchStrings = "SELECT * FROM Customers WHERE Creditinfochecked=0";
        //        SqlCommand cmd = new SqlCommand(fetchStrings, con);
        //        cmd.Parameters.AddWithValue("@currentdate", DateTime.Now);
        //        try
        //        {
        //            con.ConnectionString = connectionString;
        //            con.Open();

        //            using (SqlDataReader read = cmd.ExecuteReader())
        //            {

        //                while (read.Read())
        //                {
        //                    NationalId = Convert.ToString((read["ID_NO_OR_PASSPORT"]));
        //                    MobilePhone = Convert.ToString((read["MOBILE_NUMBER"]));
        //                    AgeOfBusiness = 12;
        //                    NDaysInRollover = (read["borrowerphone"]).ToString();
        //                }
        //            }
        //            con.Close();


        //        }

        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //        }

        //    }

        //    BeginStrategyClass request = JsonConvert.DeserializeObject<BeginStrategyClass>(receivedjson);
        //    CreditInfoResponse response = new CreditInfoResponse();
        //    string infodecision = "";

        //    if (request == null)
        //    {
        //        response.Description = "Required Field(s) are Missing";
        //    }
        //    else
        //    {
        //        string childName = "";
        //        soapEnvelope = await BeginStrategy.getInstance().CreateSoapEnvelope(request.NationalId, request.ExistingCustomer, request.MobilePhone, request.AgeOfBusiness, request.SalesTurnover, request.NDaysInRollover, request.NDeclinedApplicationsL3m, request.RepaymentScore, request.DateOfLastLimitChange);
        //        xmlDocument = new XmlDocument();
        //        xmlDocument.LoadXml(soapEnvelope);
        //        XmlNodeList nodes = xmlDocument.GetElementsByTagName("BeginStrategyResult");
        //        int Count = 0;
        //        string token = xmlDocument.GetElementsByTagName("Token")[0].InnerText;


        //        if (nodes != null)
        //        {
        //            foreach (XmlNode node in nodes)
        //            {

        //                response.Token = node["Token"].InnerText;
        //                response.Description = "Success";
        //                response.FaultCode = "0";

        //                soapEnvelope = await BeginStrategy.getInstance().CreateSoapEnvelopeEndStrat(response.Token);

        //                xmlDoc = new XmlDocument();
        //                xmlDoc.LoadXml(soapEnvelope);
        //                XmlNodeList nodesEND = xmlDoc.GetElementsByTagName("Response");
        //                XmlNodeList fault = xmlDoc.GetElementsByTagName("detail");
        //                while (fault.Count > 0 && Count <= 20)
        //                {
        //                    response.FaultCode = "1";
        //                    soapEnvelope = await BeginStrategy.getInstance().CreateSoapEnvelopeEndStrat(response.Token);

        //                    // To convert an XML node contained in string xml into a JSON string   
        //                    XmlDocument doc = new XmlDocument();
        //                    doc.LoadXml(soapEnvelope);
        //                    jsonText = JsonConvert.SerializeXmlNode(doc);

        //                    // To convert JSON text contained in string json into an XML node
        //                    XmlDocument dc = JsonConvert.DeserializeXmlNode(jsonText);


        //                    xmlDc = new XmlDocument();
        //                    xmlDc.LoadXml(soapEnvelope);
        //                    nodesEND = xmlDc.GetElementsByTagName("Response");
        //                    fault = xmlDc.GetElementsByTagName("detail");
        //                    Count++;
        //                }
        //                SqlCommand Creditinfoupdate = new SqlCommand("Updatecreditstatus", con);
        //                using (SqlDataAdapter sda = new SqlDataAdapter())
        //                {
        //                    Creditinfoupdate.CommandType = CommandType.StoredProcedure;
        //                    Creditinfoupdate.Parameters.AddWithValue("@SoapEnvelope", jsonText);
        //                    Creditinfoupdate.Parameters.AddWithValue("@Creditinfochecked", 1);
        //                    Creditinfoupdate.Parameters.AddWithValue("@loanid", MobilePhone);
        //                    Creditinfoupdate.Parameters.AddWithValue("@Penalty", penalty);
        //                    con.ConnectionString = connectionString;
        //                    con.Open();
        //                    int successStus = Creditinfoupdate.ExecuteNonQuery();
        //                    con.Close();


        //                }

        //            }

        //            ////////end
        //        }

        //        else
        //        {
        //            //not found 
        //            infoAdvise.FaultCode = "1";
        //        }


        //    }
        //    var jsonSerialiser = new JavaScriptSerializer();
        //    var json = new JavaScriptSerializer().Serialize(jsonText);
        //    string example = json.ToString();

        //    return soapEnvelope;

        //}







        #region Credit Info Advisory
        string soapEnvelope = "";
        string jsonText = "";
        XmlDocument xmlDocument;
        XmlDocument xmlDoc;
        XmlDocument xmlDc;
        CreditAdvisoryPlan infoAdvise = new CreditAdvisoryPlan();
        [Route("SabuniApi")]
        [HttpPost]
        public async Task<string> CreditInfoRequestAsync()
        {
            string NationalId = "";
            string ExistingCustomer = "True";
            string MobilePhone = "";
            string AgeOfBusiness = "1";
            string SalesTurnover = "3000";
            string NDaysInRollover = "4";
            string NDeclinedApplicationsL3m = "0";
            string RepaymentScore = "600";
            string DateOfLastLimitChange = "2019-11-25";

            int pendingchecks = 0;

            //getting number of txn to be rolled over
            var countquery = "select count(userid) as count from customers where Creditinfochecked=0  ";
            SqlCommand cmdcount = new SqlCommand(countquery, con);

            con.ConnectionString = connectionString;
            con.Open();
            using (SqlDataReader read = cmdcount.ExecuteReader())
            {
                while (read.Read())
                {

                    pendingchecks = Convert.ToInt32((read["count"]));
                }

                con.Close();


            }
            con.Close();
            int i;
            for (i = 0; i < pendingchecks; i++)
            {

                var fetchStrings = "SELECT * FROM Customers WHERE Creditinfochecked=0";
                SqlCommand cmd = new SqlCommand(fetchStrings, con);
                //cmd.Parameters.AddWithValue("@currentdate", DateTime.Now);

                con.ConnectionString = connectionString;
                con.Open();

                using (SqlDataReader read = cmd.ExecuteReader())
                {

                    while (read.Read())
                    {
                        NationalId = Convert.ToString((read["ID_NO_OR_PASSPORT"]));
                        MobilePhone = Convert.ToString((read["MOBILE_NUMBER"]));
                        AgeOfBusiness = "12";



                    }
                }
                con.Close();

                //BeginStrategyClass request = JsonConvert.DeserializeObject<BeginStrategyClass>(receivedjson);
                CreditInfoResponse response = new CreditInfoResponse();
                //string infodecision = "";

                //if (request == null)
                //{
                //    response.Description = "Required Field(s) are Missing";
                //}
                //else
                //{
                    string childName = "";
                    soapEnvelope = await BeginStrategy.getInstance().CreateSoapEnvelope(NationalId, ExistingCustomer, MobilePhone, AgeOfBusiness, SalesTurnover,NDaysInRollover, NDeclinedApplicationsL3m, RepaymentScore, DateOfLastLimitChange);
                    xmlDocument = new XmlDocument();
                    xmlDocument.LoadXml(soapEnvelope);
                    XmlNodeList nodes = xmlDocument.GetElementsByTagName("BeginStrategyResult");
                    int Count = 0;
                    string token = xmlDocument.GetElementsByTagName("Token")[0].InnerText;


                    if (nodes != null)
                    {
                        foreach (XmlNode node in nodes)
                        {

                            response.Token = node["Token"].InnerText;
                            response.Description = "Success";
                            response.FaultCode = "0";

                            soapEnvelope = await BeginStrategy.getInstance().CreateSoapEnvelopeEndStrat(response.Token);

                            xmlDoc = new XmlDocument();
                            xmlDoc.LoadXml(soapEnvelope);
                            XmlNodeList nodesEND = xmlDoc.GetElementsByTagName("Response");
                            XmlNodeList fault = xmlDoc.GetElementsByTagName("detail");
                            while (fault.Count > 0 && Count <= 20)
                            {
                                response.FaultCode = "1";
                                soapEnvelope = await BeginStrategy.getInstance().CreateSoapEnvelopeEndStrat(response.Token);
                                // To convert an XML node contained in string xml into a JSON string   
                                XmlDocument doc = new XmlDocument();
                                doc.LoadXml(soapEnvelope);
                                jsonText = JsonConvert.SerializeXmlNode(doc);

                                // To convert JSON text contained in string json into an XML node
                                XmlDocument dc = JsonConvert.DeserializeXmlNode(jsonText);


                                xmlDc = new XmlDocument();
                                xmlDc.LoadXml(soapEnvelope);
                                nodesEND = xmlDc.GetElementsByTagName("Response");
                                fault = xmlDc.GetElementsByTagName("detail");
                                Count++;
                            }
                            if (nodesEND.Count != 0)
                            {
                                foreach (XmlNode nodeEND in nodesEND)
                                {
                                    //Debug.WriteLine(nodeEND.ChildNodes[0].Name.ToString());
                                    //Debug.WriteLine(" Status " + nodeEND["status"].InnerText);
                                    response.Token = "";
                                    response.Description = "";
                                    response.FaultCode = "0";

                                    nodesEND = xmlDc.GetElementsByTagName("response");
                                    XNamespace.Get("http://creditinfo.com/schemas/2012/09/MultiConnector/Connectors/INT/IdmStrategy/Response");
                                    foreach (XmlNode noderesponse in nodesEND[1])
                                    {
                                        if (noderesponse.Name.Equals("Result"))
                                        {
                                            infoAdvise.RecommendedDecision = noderesponse["RecommendedDecision"].InnerText;
                                            infoAdvise.CreditLimit = noderesponse["CreditLimit"].InnerText;
                                        }
                                        if (noderesponse.Name.Equals("GeneralInformation"))
                                        {
                                            infoAdvise.SubjectIDNumber = noderesponse["SubjectIDNumber"].InnerText;
                                        }
                                        if (noderesponse.Name.Equals("ScoringAnalysis"))
                                        {
                                            infoAdvise.CIPScore = noderesponse["CIPScore"].InnerText;
                                            infoAdvise.CIPRiskGrade = noderesponse["CIPRiskGrade"].InnerText;
                                            infoAdvise.MobileScore = noderesponse["MobileScore"].InnerText;
                                            infoAdvise.MobileScoreRiskGrade = noderesponse["MobileScoreRiskGrade"].InnerText;
                                        }

                                        SqlCommand Creditinfoupdate = new SqlCommand("Updatecreditstatus", con);
                                        using (SqlDataAdapter sda = new SqlDataAdapter())
                                        {
                                            Creditinfoupdate.CommandType = CommandType.StoredProcedure;
                                            Creditinfoupdate.Parameters.AddWithValue("@SoapEnvelope", jsonText);
                                            Creditinfoupdate.Parameters.AddWithValue("@Creditinfochecked", 1);
                                            Creditinfoupdate.Parameters.AddWithValue("@phone", MobilePhone);
                                            Creditinfoupdate.Parameters.AddWithValue("@@reccomendation", infoAdvise.RecommendedDecision);
                                            Creditinfoupdate.Parameters.AddWithValue("@customerlimit", infoAdvise.CreditLimit);
                                            Creditinfoupdate.Parameters.AddWithValue("@CIPScore", infoAdvise.CIPScore);
                                            Creditinfoupdate.Parameters.AddWithValue("@CIPRiskGrade", infoAdvise.CIPRiskGrade);
                                            Creditinfoupdate.Parameters.AddWithValue("@MobileScore", infoAdvise.MobileScore);
                                            Creditinfoupdate.Parameters.AddWithValue("@MobileScoreRiskGrade", infoAdvise.MobileScoreRiskGrade);
                                            con.ConnectionString = connectionString;
                                            con.Open();
                                            int successStus = Creditinfoupdate.ExecuteNonQuery();
                                            con.Close();
                                        }

                                    }


                                }
                            }
                            else
                            {

                                infoAdvise.FaultCode = "1";
                            }

                        }

                        ////////end
                    }

                    else
                    {
                        //not found 
                        infoAdvise.FaultCode = "1";
                    }


                }
            
            var jsonSerialiser = new JavaScriptSerializer();
            var json = new JavaScriptSerializer().Serialize(infoAdvise);
            string example = json.ToString();

            return example;

        }
        //[Route("creditinfotest")]
        //[HttpGet]
        //public async Task<string> creditinfotest()
        //{

        //    string result = await creditonfocheckAsync("30000658", "false", "254700133282", "12", "1000", "0"
        //        , "90", "2019-10-01T00:00:00", "true", "0");


        //    return result;

        //}


        //[Route("creditonfocheck")]
        //[HttpGet]
        //public async Task<string> creditonfocheckAsync(string NationalId, string ExistingCustomer, string MobilePhone,
        //   string AgeOfBusiness, string SalesTurnover, string NDeclinedApplicationsL3m, string RepaymentScore
        //    , string DateOfLastLimitChange, string Consent, string NDaysInRollover)
        //{

        //    CreditInfoRequest cr = new CreditInfoRequest();
        //    cr.NationalId = NationalId;
        //    cr.ExistingCustomer = ExistingCustomer;
        //    cr.MobilePhone = MobilePhone;
        //    cr.AgeOfBusiness = AgeOfBusiness;
        //    cr.SalesTurnover = SalesTurnover;
        //    cr.NDeclinedApplicationsL3m = NDeclinedApplicationsL3m;
        //    cr.RepaymentScore = RepaymentScore;
        //    cr.DateOfLastLimitChange = DateOfLastLimitChange;
        //    cr.Consent = Consent;
        //    cr.NDaysInRollover = NDaysInRollover;

        //    string serializedBodyRequest = JsonConvert.SerializeObject(cr);

        //    string results = await CreditInfoRequestAsync(serializedBodyRequest);

        //    return results;








        //}
        //#endregion








        //[Route("creditinfotest")]
        //[HttpGet]
        //public async Task<string> creditinfotest()
        //{

        //    string result = await creditonfocheckAsync("30000658", "false", "254700133282", "12", "1000", "0"
        //        , "90", "2019-10-01T00:00:00", "true", "0");


        //    return result;

        //}


        //[Route("creditonfocheck")]
        //[HttpGet]
        //public async Task<string> creditonfocheckAsync(string NationalId, string ExistingCustomer, string MobilePhone,
        //   string AgeOfBusiness, string SalesTurnover, string NDeclinedApplicationsL3m, string RepaymentScore
        //    , string DateOfLastLimitChange, string Consent, string NDaysInRollover)
        //{

        //    CreditInfoRequest cr = new CreditInfoRequest();
        //    cr.NationalId = NationalId;
        //    cr.ExistingCustomer = ExistingCustomer;
        //    cr.MobilePhone = MobilePhone;
        //    cr.AgeOfBusiness = AgeOfBusiness;
        //    cr.SalesTurnover = SalesTurnover;
        //    cr.NDeclinedApplicationsL3m = NDeclinedApplicationsL3m;
        //    cr.RepaymentScore = RepaymentScore;
        //    cr.DateOfLastLimitChange = DateOfLastLimitChange;
        //    cr.Consent = Consent;
        //    cr.NDaysInRollover = NDaysInRollover;

        //    string serializedBodyRequest = JsonConvert.SerializeObject(cr);

        //    string results = await CreditInfoRequestAsync(serializedBodyRequest);

        //    return results;








        //}
        #endregion
        private static object XmlDeserializeFromString(Type type, string objectData)
        {
            //objectData = RemoveInvalidXmlCharacters(objectData);//customizeoption if you know the xml you receive wont have any invalid characters you can remove this function

            var serializer = new XmlSerializer(typeof(XmlElement));
            object result;
            using (var reader = new StringReader(objectData))
            {
                result = serializer.Deserialize(reader);
            }
            return result;
        }

    }
}
