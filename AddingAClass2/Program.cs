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
            FileStream fs = new FileStream("/home/alex/Temp/data4.txt", FileMode.Create,FileAccess.Write, FileShare.ReadWrite);
            TextWriter tw = new StreamWriter(fs);
            tw.WriteLine("Testing");
            tw.Flush();
            tw.Close();
            fs.Close();
            Console.WriteLine("Press any key to continue ....");
            Console.ReadKey();
        }
    }
}
