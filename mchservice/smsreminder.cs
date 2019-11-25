using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace mchservice
{
  public  class smsreminder
    {
        public const string connectionString = "server=197.232.70.193,50003;" + "initial catalog=MICROCAP_HOLD;" + "user id=sa;" + "password=123456";
        public void smsr()
            {
       

            int result;
                SqlConnection con = new SqlConnection();
                using (SqlCommand cmd = new SqlCommand("SP_SMSREMINDER"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;



                        cmd.Connection = con;
                        con.ConnectionString = connectionString;
                        con.Open();
                        result = Convert.ToInt32(cmd.ExecuteScalar());
                        con.Close();
                    }
                }

            }

        }
    }

