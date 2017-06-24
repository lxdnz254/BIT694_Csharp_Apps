using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ReadFromFile1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example of reading a file");
            String myLine;
            String[] words; //array of words
            /* Manually build a text file and write the content
                    Brain Adams 1960 11 5
                    Phil Colin 1951 11 30
                    John Key 1961 8 8
                    Julia Roberts 1967 10 28
                    Tom Cruise 196 7 3
             */
             // The task of this program is to read the file line by line
             TextReader tr = new StreamReader(new FileStream("/home/alex/Temp/data.txt", FileMode.Open, FileAccess.Read)); // Make sure you added "using System.IO"
             while ((myLine = tr.ReadLine()) != null)
             {
                 words = myLine.Split(' '); 
                 String firstName = words[0];
                 String lastName = words[1];
                 int year = int.Parse(words[2]);
                 int month = int.Parse(words[3]);
                 int day = int.Parse(words[4]);
                 Console.WriteLine(firstName + " " + lastName + " "
                                    + year+"/"+month+"/"+day);
                 Console.WriteLine("Press a key for next entry ...");
                 Console.ReadKey();
             } //end of reading the file
             Console.WriteLine("End of file. Press any key to continue ...");
             Console.ReadKey();
             return;
        } //end of main method

    } // end of class
}
