using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WritingToFile1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example of reading/writing files");
            String myLine;

            //How to write to a file. When writing to a file, if the file does not exist, the program creates it.
            FileStream fs = new FileStream("/home/alex/Temp/output3.txt", FileMode.Create,FileAccess.Write, FileShare.ReadWrite); // FileMode.Create overwites an existing file
            System.IO.TextWriter tw = new System.IO.StreamWriter(fs);
            StreamWriter sw = new StreamWriter(fs);
            
            for (int i=0; i < 3; i++) // read from the screen three lines and write them to a file
            {
                Console.WriteLine("Enter a line");
                myLine = Console.ReadLine(); // Read a line from the screen - could be several words
                tw.WriteLine(myLine); // Write the line to the file
            } // end of writing to the file
            tw.Flush(); //flush the file! If you do not flush the file, it will not be written. tw.Close() does not exist anymore.
            tw.Dispose(); // How to close a TextWriter file in netcoreapp1.1
            FileStream fr = new FileStream("/home/alex/Temp/output3.txt", FileMode.Open, FileAccess.Read);
            TextReader tr = new StreamReader(fr);
            Console.WriteLine("Reading from the file output3.txt");
            while((myLine = tr.ReadLine()) != null)
            {
                Console.WriteLine(myLine); //Writing the line to the screen
            }
            //tr.Close();
            Console.WriteLine("Press any key to continue .....");
            Console.ReadKey();
            return;
        } //end of main method
    } //end of class
}
