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
            Console.ForegroundColor = ConsoleColor.Green;
            }
        }
    }