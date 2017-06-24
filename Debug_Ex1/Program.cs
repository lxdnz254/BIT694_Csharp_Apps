using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debug_Ex1
{
    class Program
    {
        static void method(int n)
        {
            int i = n;
            Console.WriteLine("I am in method and the value of i is: " + i);
            if (i == 4)
            {
                return;
            }
            method(n+1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, I am going to show you something interesting");
            method(0);
            Console.WriteLine("Press any key to continue .....");
            Console.ReadKey();
            return;
        } // end of main method
    } // end of class
}
