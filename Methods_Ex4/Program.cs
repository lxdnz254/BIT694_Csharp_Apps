using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Ex4
{
    class Program
    {
        static void method1(int n)
        {
            Console.WriteLine("Hi, I am in method and the value of n is: "+n);
            method1(n-1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, I am in the main function\n");
            method1(5);
            Console.WriteLine("Press any key to continue .....");
            Console.ReadKey();
        } //end of main method
    } // end of class
}
