using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Enter the string for create Palindrome:");
            string check = Console.ReadLine();
            int i = check.Length;
            while(i> 0)
            {
                Console.Write(check.ElementAt(i-1));
                i--;
            }
            Console.ReadKey();
            */

            Console.Write("Enter the string for identifying for the Palindrome or not:");
            string check = Console.ReadLine();
            string reverse = string.Empty;
            if (check.Length >0)
            {
                for(int i = check.Length -1; i>=0; i--)
                {
                    reverse += check[i].ToString();
                }
                if (reverse == check)
                {
                    Console.WriteLine("Entered string is palindrom");
                }
                else
                {
                    Console.WriteLine("Entered string is not palindrom");
                }
            }
            else
            {
                Console.WriteLine("Please enter the string");
            }
           
            Console.ReadKey();
        }


    }
}
