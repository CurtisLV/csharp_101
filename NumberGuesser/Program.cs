// Namespace
namespace NumberGuesser
    {
    // Main Class
    internal class Program
        {
        // Entry Point method
        static void Main(string[] args)
            {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Kārlis M.";

            // Change console text color
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{appName}: Version {appVersion} by {appAuthor}");
            Console.ResetColor();

            Console.WriteLine("What is your name?");
            string inputName = Console.ReadLine();

            Console.WriteLine($"Hello, {inputName}! Let's play a game...");

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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter an actual number!");
                    Console.ResetColor();
                    continue;
                }

               

                // Cast to int and put in guess
                guess = Int32.Parse(input);

                // Match guess to correct number
                if (guess != correctNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong number, please try again!");
                    Console.ResetColor();
                }

            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You guessed correctly!!!");
            Console.ResetColor();


        }
        }
    }