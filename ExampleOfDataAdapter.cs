using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ADONETJioMart
{
    public class ExampleOfDataAdapter
    {
        public static void JioMartSelectDataFromUserCart()
        {
            SqlConnection sqlConnection = new SqlConnection(
                ConfigurationManager.ConnectionStrings["ConnectwithLocalDatabase"].ToString());

            string retriveUserDetails = "select* from JioMart.UserDetails";
            string retriveCartDetails = "select * from JioMart.CartDetails";


            SqlDataAdapter da = new SqlDataAdapter();
            SqlDataAdapter da1 = new SqlDataAdapter();

            da.SelectCommand = new SqlCommand(retriveUserDetails, sqlConnection);
            da1.SelectCommand = new SqlCommand(retriveCartDetails, sqlConnection);

            Console.WriteLine("----------------------using DataSet-------------");
            DataSet ds = new DataSet();
            DataSet ds1 = new DataSet();

            da.Fill(ds);
            da1.Fill(ds1);

            Console.WriteLine("----------------------using DataSet print UserDetails-------------");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine("{0} {1} {3} {4}", row[0] + "\t", row[1] + "\t", row[2] + "\t", row[3] + "\t", row[4] + "\t");
            }

            Console.WriteLine("----------------------using DataSet print CartDetails-------------");
            foreach (DataRow row in ds1.Tables[0].Rows)
            {
                Console.WriteLine("{0} {1} {3} {4}", row[0] + "\t", row[1] + "\t", row[2] + "\t", row[3] + "\t", row[4] + "\t");
            }
            
                        Console.WriteLine("------------------------using  UserDetails dataTable----------");
             
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();

            da.Fill(dt);
            da.Fill(dt1);

            foreach (DataRow row in dt.Rows)
                 {
                     Console.WriteLine("{0} {1} {3} {4}", row[0], row[1], row[2], row[3], row[4]);
                 }

            foreach (DataRow row in dt1.Rows)
            {
                Console.WriteLine("{0} {1} {3} {4}", row[0], row[1], row[2], row[3], row[4]);
            }

            Console.ReadKey();
        }

    }
}
