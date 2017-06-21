using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableTypesIOBasicCommands1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string"); //Writing to the screen (Console)
            String line = Console.ReadLine(); // Reading from the screen (Console)
            Console.WriteLine("The string you entered was: " + line);
            Console.WriteLine("Enter an integer"); //Writing to the scren (Console)
            line = Console.ReadLine(); //Reading from the screen (Console)
            int n = int.Parse(line);
            Console.WriteLine("The result of adding one to the number you entered is: " + (n+1));
            Console.WriteLine("Enter a value (double)"); //Writing to the screen (Console)
            line = Console.ReadLine(); //Reading from the screen (Console)
            double a = double.Parse(line);
            Console.WriteLine("Here is the square of the value you entered: "  + a*a);
            Console.WriteLine("Press a key to continue ...");
            Console.ReadKey();
        }   // end of main method
    }   // end of main class
}
