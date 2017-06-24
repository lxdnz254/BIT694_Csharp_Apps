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
            TextWriter tw = new StreamWriter("/home/alex/Temp/data2.txt");
            tw.WriteLine("Testing");
            tw.Close();
            Console.WriteLine("Press any key to continue ....");
            Console.ReadKey();
        }
    }
}
