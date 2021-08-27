using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Guesser
{
    class Program
    {
        static void Main(string[] args)
        {

            GetAppInfo(); //Run GetAppInfo Function to get info

            GetUserInfo(); // Ask for users name and greet;

            while (true)
            {


                //int correctNumber = 7;

                //Create a new Random object;
                Random random = new Random();

                //Init correct number 
                int correctNumber = random.Next(1, 10);

                //Init guess var
                int guessNumber = 0;

                //Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");
                //while guess is not correct
                while (guessNumber != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guessNumber))
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use and actual number");

                        continue;
                    }

                    //Cast to int and put in guess
                    guessNumber = Int32.Parse(input);

                    //Match guess to correct number
                    if (guessNumber != correctNumber)
                    {
              
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again!");
                    }
                }

                //Print success message
                PrintColorMessage(ConsoleColor.Yellow, "You are Correct!!!!!");

                //Ask to play again
                Console.WriteLine("Play again? [Y or N]");


                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else {
                    return;
                }
            }
        }
        static void GetAppInfo() {
            //Start Here
            string appName = "Number Guesser";
        string appVersion = "1.0.0";
        string appAuthor = "Martin Fernandez";

        //Change Text color
        Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0}:Version {1} by {2}", appName, appVersion, appAuthor);
            //Reset text color
            Console.ResetColor();
        }

        static void GetUserInfo() {
            //Ask users name
            Console.WriteLine("What is your name? ");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0} , Let's play a game....", inputName);
        }

        //Print color message
        static void PrintColorMessage(ConsoleColor color, string message) {
            //Change Text color
            Console.ForegroundColor = color;

            //Tell User is not a number
            Console.WriteLine(message);
            //Reset text color
            Console.ResetColor();

        }

    }
}
