using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AddingAClass2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, welcome to the netcore version of adding a class");
            Person p = new Person("John", "Key", "9-August-1961", 111); // Creating the first object
            Person q = p;
            Console.WriteLine("Press any key to continue ....");
            Console.ReadKey();
        }
    }
}
