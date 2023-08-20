using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //create an instance with data type string
            Student<string> studentName = new Student<string>();

            //create an instance with data type int
            Student<int> studentId = new Student<int>();

            studentName.Data = "Rajesh Patel";
            Console.WriteLine(studentName.Data);



            //calling function with string data
            studentName.displayData("Aman");

            //calling function with integer data
            studentId.displayData(15);
            Console.ReadKey();
        }
    }

    public class Student<T>
    {
        public T Data;

        public T data
        {
            get { return Data; }
            set { Data = value; }
        }
        ////constuctor
        //public Student(T Data)
        //{
        //    this.Data = Data;
        //    Console.WriteLine($"Data Passed is: {this.Data}");       
        //}

        public void displayData(T Data)
        {
            Console.WriteLine($"this is the for pass the data{Data}");
        }
    }
}
