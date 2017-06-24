using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] A = new int[5]; // Declaring an array of five integers

            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine("Enter the number for the: " + i + "th element");
                A[i] = int.Parse(Console.ReadLine());
            }
            // Writing the numbers you entered in reverse order
            Console.WriteLine("The elements you entered in reverse order: ");
            for (int i = A.Length-1; i>=0; i--)
            {
                Console.WriteLine("The value of "+i+"-th element is: "+ A[i]);
            }
            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        } // end of main method
    } // end of class
} // end of namespace
