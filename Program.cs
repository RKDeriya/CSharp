using JioMartGeneric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JioMartGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Base<DateTime,DateTime> objbase = new Base<DateTime,DateTime>();
            objbase.CreatedOn = DateTime.Now;
            objbase.UpdatedOn = DateTime.Now;

            UserDetails objUserDetails = new UserDetails();
            objUserDetails.UserDetailsId = 1;
            objUserDetails.UserFirstName = "Aman";
            objUserDetails.UserLastName = "Gupta";
            objUserDetails.UserAddress = "Kalol,Gandhinagar";
            objUserDetails.UserMobileNo = "123456789";
            objUserDetails.UserWalletBalance = 0;
            objbase.CreatedOn = DateTime.Now;
            objbase.UpdatedOn = DateTime.Now;


            Console.WriteLine($"UserDetailsId:{objUserDetails.UserDetailsId}");
            Console.WriteLine($"UserFirstname:{objUserDetails.UserFirstName}");
            Console.WriteLine($"Userlastname:{objUserDetails.UserLastName}");
            Console.WriteLine($"UserAdress:{objUserDetails.UserAddress}");
            Console.WriteLine($"UserMobileNo:{objUserDetails.UserMobileNo}");
            Console.WriteLine($"UserMobileNo:{objUserDetails.UserMobileNo}");
            Console.WriteLine($"UserWalletBalance:{objUserDetails.UserWalletBalance}");
            Console.WriteLine($"CreatedOn:{objUserDetails.CreatedOn}");
            Console.WriteLine($"UpdatedOn:{objUserDetails.UpdatedOn}");
            Console.ReadKey();
        }
    }

    public class Base<T,I>
    {
        public T CreatedOn { get; set; }
        public I UpdatedOn { get; set; }
    }
    public class UserDetails : Base<DateTime,DateTime>
    {

        public int UserDetailsId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserAddress { get; set; }
        public string UserMobileNo { get; set; }
        public float UserWalletBalance { get; set; }
    }

    public class Category : Base<DateTime, DateTime>
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }

    public class ProductDetails : Base<DateTime, DateTime>
    {
        public int ProductDetailsId { get; set; }
        public string ProductName { get; set; }
        public float ProductPrice { get; set; }
        public int ProductStockQuantity { get; set; }
        public int CategoryId { get; set; }

    }

    public class CartDetails : Base<DateTime, DateTime>
    {
        public int CartDetailsId { get; set; }
        public int ProductDetailsId { get; set; }
        public int ProductQuantity
        {
            get; set;
        }
        public float CartTotalPrice { get; set; }
        public string CartOrderStatus { get; set; } = "Not Complete";
        public int UserDetailsId { get; set; }

    }

    public class OrderDetails : Base<DateTime, DateTime>
    {
        public int OrderDetailsId { get; set; }
        public int CartDetailsId { get; set; }
        public string OrderPaymentMode { get; set; }
        public int OrderTotalPrice { get; set; }
        public string OrderDeliveryStatus { get; set; } = "InProgress";
        public DateTime OrderDate { get; set; }

    }

}
