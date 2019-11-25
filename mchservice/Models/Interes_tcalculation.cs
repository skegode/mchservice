using CemesWebService.Models;


using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

using System.Data;
using System.Diagnostics;
using System.Security.Cryptography;
using Newtonsoft.Json.Linq;

using System.Configuration;


using Newtonsoft.Json;

using Nancy.Json;
namespace CemesWebService.Models
{
    public class Interes_tcalculation
    {
        String CS = "Data Source=197.232.70.193,50003;initial catalog=MICROCAP_HOLD;user id=sa;pwd=123456";
        SqlConnection con = new SqlConnection();

        private Double getcharge(int productid, Double amount)
        {
            Double charge = 0;
            String fetchrate = "SELECT InterestValue FROM InterestBands WHERE ProdID=@productid AND (@amnt BETWEEN LowerBand AND UpperBand)";
            SqlConnection con = new SqlConnection();
            SqlCommand cmdrate = new SqlCommand(fetchrate, con);
            cmdrate.Parameters.AddWithValue("@productid", Convert.ToInt32(productid));
            cmdrate.Parameters.AddWithValue("@amnt", Convert.ToDouble(amount));

            con.ConnectionString = CS;
            con.Open();
            using (SqlDataReader read = cmdrate.ExecuteReader())
            {
                while (read.Read())
                {


                    charge = Convert.ToDouble(read["InterestValue"].ToString());
                }
            }

            con.Close();
            return charge;
        }
        private int  interestMethod(int productid)
        {

            int InterestMethod = 0;
            String fetchproducts = "select * from ProductDefView WHERE Id=@productid";
            SqlCommand cmds = new SqlCommand(fetchproducts, con);
            cmds.Parameters.AddWithValue("@productid", Convert.ToInt32(productid));

            con.ConnectionString = CS;
            con.Open();
            using (SqlDataReader read = cmds.ExecuteReader())
            {
                while (read.Read())
                {

                    InterestMethod = Convert.ToInt32(read["InterestMethodId"].ToString());
                }
            }

            con.Close();

            return InterestMethod;
        }
    
     

            public int calculateinterest(string productid, string amount, string period)
            {

                  
              

            int proid = Convert.ToInt32(productid);
            Double amt = Convert.ToDouble(amount);
            Double charge = getcharge(proid, amt);
            int InterestMethod = interestMethod(proid);
            int result = 0;


            Double r = charge / 100;
            Double MonthlyInterest;
            Double InterestAmount = 0;



                if (InterestMethod == 1) //Declining rate
                {


                    MonthlyInterest = ((r / 12) / (1 - (Math.Pow((1 + (r / 12)), -(Convert.ToInt32(period)))))) * Convert.ToDouble(amount);
                    InterestAmount = MonthlyInterest * Convert.ToInt32(period);





                }
                else if (InterestMethod == 2)//flat rate
                {


                    double PrincipleMonthlyPayment = Convert.ToDouble(amount) / Convert.ToInt32(period);
                    double annualInterest = (r / 100) * Convert.ToDouble(amount);
                    double interestPerMonth = annualInterest / Convert.ToInt32(amount);

                    MonthlyInterest = (interestPerMonth);
                    InterestAmount = MonthlyInterest * Convert.ToInt32(period);




                }


                else if (InterestMethod == 3) //fixed Fee
                {

                    InterestAmount = charge;


                }

                using (SqlCommand cmd = new SqlCommand("CPS_Mobileloancalculator"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@principle", amount);
                        cmd.Parameters.AddWithValue("@Period", period);
                        cmd.Parameters.AddWithValue("@ProductId", productid);
                        cmd.Parameters.AddWithValue("@InterestAmount", InterestAmount);
                        cmd.Connection = con;
                        con.ConnectionString = CS;
                        con.Open();
                        result = Convert.ToInt32(cmd.ExecuteScalar());
                        con.Close();

                        return result;
                    }
                }
            }
        public Double interestAmount(int productid,int period,Double amount)
        {
           
         
            int InterestMethod= interestMethod(productid);
            Double charge = getcharge(productid,amount);
            Double r = charge / 100;
            Double MonthlyInterest;
            Double InterestAmount = 0;



            if (InterestMethod == 1) //Declining rate
            {


                MonthlyInterest = ((r / 12) / (1 - (Math.Pow((1 + (r / 12)), -(period))))) * (amount);
                InterestAmount = MonthlyInterest * Convert.ToInt32(period);

            }
            else if (InterestMethod == 2)//flat rate
            {


                double PrincipleMonthlyPayment = (amount) /(period);
                double annualInterest = (r / 100) * (amount);
                double interestPerMonth = annualInterest / Convert.ToInt32(period);

                MonthlyInterest = (interestPerMonth);
                InterestAmount = MonthlyInterest * Convert.ToInt32(period);




            }


            else if (InterestMethod == 3) //fixed Fee
            {

                InterestAmount = charge;


            }
            return InterestAmount;
        }
        }
    }

