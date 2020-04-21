
//program to create a console game of guessing random number

using System;


namespace console_app_beginning
{
    class Program
    {
        static void Main(string[] args)
        {
            // calling game info
            GameInfo();
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();
            while (true)
            {
                Console.WriteLine("{0}, Let's play the game!", name);
                //creating random correct number between 1 and 10
                Random random = new Random();
                int CorrectNumber = random.Next(1, 10);

                colorchange(ConsoleColor.Blue,"\n \t \t WELCOME TO GAME");
                int guess = 0;
                Console.WriteLine("\n Guess the Number between 1 and 10: ");




                while (guess != CorrectNumber)
                {
                    // reading from user

                    string input = Console.ReadLine(); // input from user
                    guess = Int32.Parse(input); // type casting from string to integer




                    if (guess != CorrectNumber)
                    {
                        colorchange(ConsoleColor.Red, "You have guessed it wrong. TRY AGAIN: ");

                    }
                }

                colorchange(ConsoleColor.Yellow, "You have guessed it right! CONGRATULATIONS.");

                Console.WriteLine("Do you want to play again ?[Y or N]");
                string playcontinue = Console.ReadLine().ToUpper();

                if (playcontinue == "Y")
                {
                    continue;

                }
                else if (playcontinue == "N")
                {
                    return;
                }
                else
                {
                    return;
                }


            }
        }

        static void colorchange(ConsoleColor color, string message)
        {   //changing the foreground text color 
            Console.ForegroundColor = color;
            //printing the message in color
            Console.WriteLine(message);
            //changing the color to default
            Console.ResetColor();

        }

        static void GameInfo()
        {
            string gamename = "Number Guesser";
            string name = "Sachin Giri";
            string version = "1.0.0";
            Console.ForegroundColor = ConsoleColor.Green; // changes foreground color to green
            Console.WriteLine("{0} by {1}  Version:{2} ", gamename, name, version); // using indexing in printing
            Console.ResetColor();


        }

        
    }
}
