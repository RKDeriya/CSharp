using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONETJioMart
{ 
    public class Program
    {
        static void Main(string[] args)
        {
            JioMartInsertDetails insertDetails = new JioMartInsertDetails();
            /*
            insertDetails.InsertUserDetails();
            insertDetails.InsertCategory();
            insertDetails.InsertProductDetails();
            insertDetails.InsertCartDetails();
            insertDetails.InsertOrderDetails();
            */

            JioMartUpdateDetails updateDetails = new JioMartUpdateDetails();
            //updateDetails.UpdateOrderDetailsOrderDeliveryStatus();



            JioMartDataReader dataReader = new JioMartDataReader();
            //dataReader.SelectCategory();



            // getfirst record from the userdetails
            //create connection string and adding to class
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectwithLocalDatabase"].ToString());

            //generate query
            string retriveQuery = "select top 1 UserFirstName from JioMart.UserDetails";
            SqlCommand cmd = new SqlCommand(retriveQuery, sqlConnection);
            sqlConnection.Open();
            string y=Convert.ToString(cmd.ExecuteScalar());
            sqlConnection.Close();
            Console.WriteLine(y);
            Console.ReadKey();

        }
    }

    public class JioMartInsertDetails
    {
        public void InsertuserDetailsViaInsert()
        {
            
                // Create connection string and assing to class
            SqlConnection sqlConnetion = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectwithLocalDatabase"].ToString());

                // Generate Query
                // string query = "Insert into LookupType values ('Added From Console',GETDATE())";
            string query = "insert into jiomart.UserDetails values('Karan','Shah','Income tex,Ahmedabad','8974561230',0,GETDATE(),GETDATE())";

            //Create Command
            SqlCommand cmd = new SqlCommand(query, sqlConnetion);
            sqlConnetion.Open();
            cmd.ExecuteNonQuery();
            sqlConnetion.Close();
           
        }
        public void InsertUserDetails()
        {
            //create connection string and assigning to class
            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectwithLocalDatabase"].ToString());

            //generate query
            string SpQuery = "JioMart.InsertUserDetails";

            //create command
            SqlCommand cmd = new SqlCommand(SpQuery, sqlconnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@userDetailsId", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@userFirstName", SqlDbType.VarChar).Value = "DarshanBhai";
            cmd.Parameters.Add("@userLastName", SqlDbType.VarChar).Value = "Modi";
            cmd.Parameters.Add("@userAddress", SqlDbType.VarChar).Value = "Surat,Gujarat";
            cmd.Parameters.Add("@userMobileNo", SqlDbType.VarChar).Value = "4591286570";
            cmd.Parameters.Add("@userWalletbalance", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@opType", SqlDbType.VarChar).Value = "I";

            sqlconnection.Open();
            cmd.ExecuteNonQuery();
            sqlconnection.Close();
            Console.WriteLine("data inserted successfully");
        }

        public void InsertCategory()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectwithLocalDatabase"].ToString());

            string SPQuery = "JioMart.InsertCategory";

            SqlCommand cmd = new SqlCommand(SPQuery, sqlConnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@categoryId", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@categoryName", SqlDbType.VarChar).Value = "categ"; // Set categoryName value here
            cmd.Parameters.Add("@opType", SqlDbType.VarChar).Value = "I";


            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            Console.WriteLine("data inserted successfully");
        }

        public void InsertProductDetails()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectwithLocalDatabase"].ToString());

            string SPQuery = "JioMart.InsertProductDetails";

            SqlCommand cmd = new SqlCommand(SPQuery, sqlConnection);
            //tell data insert with the help of SP
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@productDetailsId", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@productName", SqlDbType.VarChar).Value = "Mung dal"; // Set categoryName value here
            cmd.Parameters.Add("@productPrice", SqlDbType.Float).Value = 566;
            cmd.Parameters.Add("@productStockQuantity", SqlDbType.Int).Value = 100;
            cmd.Parameters.Add("@categoryId", SqlDbType.Int).Value = 10001;
            cmd.Parameters.Add("@opType", SqlDbType.VarChar).Value = "I";

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            Console.WriteLine("data inserted successfully");
        }
        public void InsertCartDetails()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectwithLocalDatabase"].ToString());

            string SPQuery = "JioMart.InsertCartDetails";

            SqlCommand cmd = new SqlCommand(SPQuery, sqlConnection);
            //tell data insert with the help of SP
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add("@cartDetailsId", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@productDetaisId", SqlDbType.Int).Value = "11";
            cmd.Parameters.Add("@productQuantity", SqlDbType.Int).Value = 3;
            cmd.Parameters.Add("@cartTotalPrice", SqlDbType.Float).Value = 930;
            cmd.Parameters.Add("@userDetailsId", SqlDbType.Int).Value = 4;
            cmd.Parameters.Add("@opType", SqlDbType.VarChar).Value = "I";

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            Console.WriteLine("data inserted successfully in cart details");

        }

        public void InsertOrderDetails()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectwithLocalDatabase"].ToString());

            string SPQuery = "jiomart.InsertOrderDetails";

            SqlCommand cmd = new SqlCommand(SPQuery, sqlConnection);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@cartDetailsId", SqlDbType.Int).Value = 101;

            cmd.Parameters.Add("@orderPaymentMode", SqlDbType.VarChar).Value = "UPI";
            cmd.Parameters.Add("@orderTotalPrice", SqlDbType.Float).Value = 620;
            cmd.Parameters.Add("@orderdeliveryStatus", SqlDbType.VarChar).Value = "11";

            sqlConnection.Open();
                cmd.ExecuteNonQuery();
            sqlConnection.Close();
            Console.WriteLine("data inserted successfully in Orderdetails");
        }
    }
    public class JioMartUpdateDetails
    {
        public void UpdateOrderDetailsOrderDeliveryStatus()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectwithLocalDatabase"].ToString());

            //create query
            string SPQuery = "jioMart.UpdateOrderDetailsOrderDeliveryStatus";

            SqlCommand cmd = new SqlCommand(SPQuery, sqlConnection);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@orderDetailsId", SqlDbType.Int).Value = 101;
            cmd.Parameters.Add("@orderdeliveryStatus", SqlDbType.VarChar).Value = "Delivered";

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

        }
    }

    //create classs for the data Read(select from the table)
    public class JioMartDataReader
    {
        public void SelectCategory()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectwithLocalDatabase"].ToString());

            SqlCommand cmd = new SqlCommand(
                  "SELECT CategoryID, CategoryName FROM JioMart.Category;",sqlConnection);


            sqlConnection.Open();

            SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}\t{1}", reader.GetInt32(0),
                            reader.GetString(1));
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader.Close();
            
        }
    }
}