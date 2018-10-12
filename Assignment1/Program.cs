using System;

namespace Assignment1
{
    class Program
    {
		// Constants for the main program
        internal const String fileLocation = "./input_assignment1.txt";
        internal const int fileLines = 20;
        internal const String titleLines = "----------------------------";

		public static void Main (string[] args)
		{
			/*
			Test t = new Test ();
			t.testCustomers ();
			t.testReadFile (fileLocation, fileLines);
			t.testDateUtilities ();
            */

			Customer[] customerArray = ReadFromFile.customerList (fileLocation, fileLines);

			// Menu loop
			bool running = true;

			while (running) {
				int option = Menu.displayMenu();	

				switch (option) {
				case 0:
					running = false;
					break;
				case 1:
					Menu.makeDeposit (customerArray);
					break;
				case 2:
					Menu.makeWithdrawl (customerArray);
					break;
				case 3:
					Menu.getMaximumBalance (customerArray);
					break;
				case 4:
					Menu.getMostActive (customerArray);
					break;
				case 5:
					Menu.getYoungest (customerArray);
					break;
				case 6:
					Menu.getLeapYearCustomers (customerArray);
					break;
				}
			} // end of Menu loop

			Console.WriteLine ("\nEnd of program, press any key to continue ...");
			Console.ReadKey ();
        }
    }
}
