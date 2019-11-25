using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace mchservice
{
    class writeoff
    {
        public const string connectionString = "server=197.232.70.193,50003;" + "initial catalog=MICROCAP_HOLD;" + "user id=sa;" + "password=123456";
        public void writeoffloans()
        {


            int result;
            SqlConnection con = new SqlConnection();
            using (SqlCommand cmd = new SqlCommand("Writeoffloans"))
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
