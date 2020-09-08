/// Lewis Morgan
/// ISM 4300 Tech Project #2a
/// September 08, 2020

using System;

namespace TechProj2_ConsoleLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            bool restart = false;
            bool exit = false;

            // Main Program loop, it will stop running when exit is true, and it will rerun when restart is true
            while (!exit || restart)
            {
                Console.WriteLine("Please enter a number between 1-25 (inclusive)");
                readInput();
                // Program main function finished. Ask the user if they want to restart the program.
                Console.WriteLine("\nPress the 'y' key to restart. Any other key will quit the program");
                char endingKey = Console.ReadKey().KeyChar;
                // Check to see if the key they entered was y
                if (endingKey == 'y' || endingKey == 'Y')
                {
                    restart = true;
                    // stops the y key from being smushed against "Please enter a number..." when restarting
                    Console.WriteLine("\n");
                } 
                else
                {
                    exit = true;
                }
            }
        }

        static void readInput() {
            string numStr = Console.ReadLine();
            int number;

            // Parse the string to a number safely, it should be between 1-25
            if (int.TryParse(numStr, out number))
            {
                // Number must be between 1 and 25, inclusive
                if (number < 1 || number > 25)
                {
                    Console.WriteLine("Your number must be between 1 and 25, inclusive");
                }
                else
                {
                    // Loop starting at 1 because it says 'Current integer in the loop is 1', going up to the number
                    for (int i = 1; i < number + 1; i++)
                    {
                        Console.WriteLine("You have entered " + numStr + ". This is the current integer value in the loop: " + i.ToString());
                    }
                }
            }
            else
            {
                // Entered user input is invalid, they should enter only integer values acceptable to TryParse for integers
                Console.WriteLine("The number you entered is not a valid integer value. You entered: " + numStr);
            }
        }
    }
}
