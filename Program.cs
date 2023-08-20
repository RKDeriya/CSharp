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
        }
    }

    public class CreatedOn<T>
    {
        public T CreatedOn { get; set; }
        public T UpdatedOn { get; set; }
    }
    public class UserDetails: CreatedOn<T>
    {
      
        public int UserDetailsId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserAddress { get; set; }
        public string UserMobileNo { get; set; }
        public float UserWalletBalance { get; set; }
    }

    public class Category: CreatedOn<T>
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }

    public class ProductDetails: CreatedOn<T>
    {
        public int ProductDetailsId { get; set; }
        public string ProductName { get; set; }
        public float ProductPrice { get; set; }
        public int ProductStockQuantity { get; set; }
        public int CategoryId { get; set; }
        
    }

    public class CartDetails: CreatedOn<T>
    {
        public int CartDetailsId { get; set; }
        public int ProductDetailsId { get; set; }
        public int ProductQuantity { get; set; 
        public float CartTotalPrice { get; set; }
        public string CartOrderStatus { get; set; } = "Not Complete";
        public int UserDetailsId { get; set; }
     
    }

    public class OrderDetails: CreatedOn<T>
{
        public int OrderDetailsId { get; set; }
        public int CartDetailsId { get; set; }
        public string OrderPaymentMode { get; set; }
        public int OrderTotalPrice { get; set; }
        public string OrderDeliveryStatus { get; set; } = "InProgress";
        public DateTime OrderDate { get; set; }
      
    }

}
