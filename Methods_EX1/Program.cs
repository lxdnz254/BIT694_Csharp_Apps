using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_EX1
{
    class Program
    {
        static void method3()
        {
            Console.WriteLine("Hi, I am in method 3");
            return;
        } //end of method 3

        static void method2()
        {
            method3();
            Console.WriteLine("Hi, I am in method 2");
            return;
        } //end of method 2

         static void method1()
        {
            Console.WriteLine("Hi, I am in method 1");
            method2();
            return;
        } //end of method 1
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, I am in the main function");
            method1(); //calling method1
            Console.WriteLine("Press any key to continue ....");
            Console.ReadKey();
        } // end of main method
    } // end of class
}
