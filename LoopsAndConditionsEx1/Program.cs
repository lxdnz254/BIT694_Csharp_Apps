using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAndConditionsEx1
{
    class Program
    {
        // Tests if number divisible by 4 or 5
        // Only prints 7 numbers per line
        // Evaluates between 1 and 100

        static void Main(string[] args)
        {
            Console.WriteLine("Hi, welcome to loops and conditions - Ex 1");
            int counter = 0;
            for (int i=1; i <= 100; i++)
            {
                if (!(((i % 4)== 0) || ((i % 5) == 0))) continue;
                counter++;
                if (counter < 7) Console.Write(i+" ");
                else
                {
                    Console.WriteLine(i+" ");
                    counter = 0;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        } // end of main method
    } // end of class
} // end of namespace
