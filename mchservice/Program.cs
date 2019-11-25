using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace mchservice
{


    public class Program
    {
        public const string connectionString = "server=197.232.70.193,50003;" + "initial catalog=MICROCAP_HOLD;" + "user id=sa;" + "password=123456";
        public const string smsdbstring = "server=197.232.70.193,50002;" + "initial catalog=FIN_SMS_EMAIL;" + "user id=sa;" + "password=123456";


        static async Task Main(string[] args)
        {

            int rolloverflag;
         
            smsreminder smsreminder = new smsreminder();
            writeoff writeoff = new writeoff();
            Rollover rollover = new Rollover();
            Sabuni sabuni = new Sabuni();
        

            string xxx=await sabuni.CreditInfoRequestAsync();

            rolloverflag = rollover.rolloverloan();

            if (rolloverflag == -1)
            {
               // writeoff.writeoffloans();
               // smsreminder.smsr();
            }
           

        }
        static void Rollover()
        {
            SqlConnection con = new SqlConnection();
            try
            {
                double currentbalance = 0, rolloverchage = 0;
                int loanid = 0, pendingloans = 0, i;
                string smsbody = "", phoneNumber = "";

                //getting number of txn to be rolled over
                var countquery = "select count(loanid) as count from VW_ROLLEDOVER where RoleoverDate<=@currentdate and ROLLEDOVER=0 OR ROLLEDOVER IS NULL ";
                SqlCommand cmdcount = new SqlCommand(countquery, con);
                cmdcount.Parameters.AddWithValue("@currentdate", DateTime.Now);
                con.ConnectionString = connectionString;
                con.Open();
                using (SqlDataReader read = cmdcount.ExecuteReader())
                {
                    while (read.Read())
                    {

                        pendingloans = Convert.ToInt32((read["count"]));
                    }

                    con.Close();


                }
                con.Close();


                //updating all loans past rolledOver date.

                for (i = 0; i < pendingloans; i++)
                {

                    var fetchStrings = "SELECT * FROM VW_ROLLEDOVER WHERE RoleoverDate<=@currentdate and ROLLEDOVER=0 OR ROLLEDOVER IS NULL";
                    SqlCommand cmd = new SqlCommand(fetchStrings, con);
                    cmd.Parameters.AddWithValue("@currentdate", DateTime.Now);
                    try
                    {
                        con.ConnectionString = connectionString;
                        con.Open();

                        using (SqlDataReader read = cmd.ExecuteReader())
                        {

                            while (read.Read())
                            {
                                currentbalance = Convert.ToDouble((read["loanbalance"]));
                                rolloverchage = Convert.ToDouble((read["RollOverFee"]));
                                loanid = Convert.ToInt32((read["loanid"]));
                                phoneNumber = (read["borrowerphone"]).ToString();
                            }
                        }
                        con.Close();

                        double penalty = (rolloverchage / 100) * currentbalance;
                        double newbalance = penalty + currentbalance;




                        SqlCommand cmdupdate = new SqlCommand("RolloverCheck", con);

                        using (SqlDataAdapter sda = new SqlDataAdapter())
                        {
                            cmdupdate.CommandType = CommandType.StoredProcedure;
                            cmdupdate.Parameters.AddWithValue("@newloanbalance", newbalance);
                            cmdupdate.Parameters.AddWithValue("@rolloverstatus", 1);
                            cmdupdate.Parameters.AddWithValue("@loanid", loanid);
                            cmdupdate.Parameters.AddWithValue("@Penalty", penalty);
                            con.ConnectionString = connectionString;
                            con.Open();
                            int successStus = cmdupdate.ExecuteNonQuery();
                            con.Close();

                            switch (successStus)
                            {
                                case 0:
                                    Console.WriteLine("There was an error updating the loan kindly view logs");
                                    Console.WriteLine();
                                    break;
                                case -1:




                                    //sending sms
                                    var smsquerystring = "SELECT * FROM SystemNotifications WHERE NotificationID=@NotificationID";
                                    SqlCommand cmdsmselect = new SqlCommand(smsquerystring, con);
                                    cmdsmselect.Parameters.AddWithValue("@NotificationID", 13);
                                    try
                                    {
                                        con.ConnectionString = connectionString;
                                        con.Open();

                                        using (SqlDataReader read2 = cmdsmselect.ExecuteReader())
                                        {

                                            while (read2.Read())
                                            {

                                                smsbody = (read2["NotificationBody"]).ToString();
                                            }
                                        }
                                        con.Close();

                                        //dumping sms to sms db
                                        string newsmsbody = smsbody.Replace("{amount}", Convert.ToString(penalty)).Replace("{newl}", Convert.ToString(newbalance));

                                        SqlCommand cmddump = new SqlCommand("InsertRolloversms", con);

                                        using (SqlDataAdapter sdadump = new SqlDataAdapter())
                                        {
                                            cmddump.CommandType = CommandType.StoredProcedure;
                                            cmddump.Parameters.AddWithValue("@phonenumber", phoneNumber);
                                            cmddump.Parameters.AddWithValue("@smsbody", newsmsbody);
                                            cmddump.Parameters.AddWithValue("@datex", DateTime.Now);
                                            cmddump.Parameters.AddWithValue("@sentStatus", 0);
                                            cmddump.Parameters.AddWithValue("@loanid", loanid);
                                            cmddump.Parameters.AddWithValue("@client", "FINSOL");
                                            con.ConnectionString = smsdbstring;
                                            con.Open();
                                            cmddump.ExecuteNonQuery();
                                            con.Close();


                                            Console.WriteLine("Loan Id:" + loanid + "has been updated successful");
                                            Console.WriteLine();


                                        }
                                    }

                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex);
                                    }
                                    break;
                            }

                        }
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        //Method to activate customers
        public void activeCustomer()
        {

            int result;
            SqlConnection con = new SqlConnection();
            using (SqlCommand cmd = new SqlCommand("ActivateCustomer"))
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

        //sms reminder

       
    }
}
