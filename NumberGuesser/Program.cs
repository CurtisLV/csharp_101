// Namespace
namespace NumberGuesser
{
    // Main Class
    internal class Program
    {
        // Entry Point method
        static void Main(string[] args)
        {
            GetAppInfo();
            GreetUser();

            while (true)
            {
                // Set correct number
                Random rand = new Random();
                int correctNumber = rand.Next(1, 11);
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    // Make sure Input is a number
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMsg(ConsoleColor.Red, "Please enter an actual number!");
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        PrintColorMsg(ConsoleColor.Red, "Wrong number, please try again!");
                    }
                }

                PrintColorMsg(ConsoleColor.Yellow, "You guessed correctly!!!");

                // Do you want to play again?
                Console.WriteLine("Play again? [Y or N]");

                string inputPlayAgain = Console.ReadLine().ToUpper();

                if (inputPlayAgain == "Y")
                {
                    continue;
                }
                else if (inputPlayAgain == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Kārlis M.";

            // Change console text color
            PrintColorMsg(ConsoleColor.Green, $"{appName}: Version {appVersion} by {appAuthor}");
        }

        static void GreetUser()
        {
            Console.WriteLine("What is your name?");
            string inputName = Console.ReadLine();
            Console.WriteLine($"Hello, {inputName}! Let's play a game...");
        }

        // Print console color msg

        static void PrintColorMsg(ConsoleColor color, string msg)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(msg);
            Console.ResetColor();
        }
    }
}
