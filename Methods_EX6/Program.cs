using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_EX6
{
    class Program
    {
        static int factorial(int n)
        {
            if (n ==1) return (1);
            return (n*factorial(n-1));
        }

        static int fibonacci(int n)
        {
            if (n <=2)  return (1);
            return (fibonacci(n-1) + fibonacci(n-2));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the main method");
            Console.WriteLine("The factorial of 5 is: " + factorial(5));
            Console.WriteLine("The fibonacci sequence number at position 2 is: " + fibonacci(2));
            Console.WriteLine("Press any key to continue .....");
            Console.ReadKey();
        }
    }
}
