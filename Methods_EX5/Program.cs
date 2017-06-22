using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_EX5
{
    class Program
    {
        static void method1(int n)
        {
            Console.WriteLine("the value of n is: " + n);
            if (n > 0)
            {
                method1(n-1);
            }
            return;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, I am in the main function\n");
            method1(5);
            Console.WriteLine("Press any key ....");
            Console.ReadKey();
        }
    }
}
