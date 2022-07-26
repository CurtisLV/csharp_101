using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      // Type your code below

      string[] questions = {
        "Is the sky blue?",
        "Is grass green?",
        "Is sun black?",
        "Are dogs barkings?",
        "Are cats barking?"
      };

      bool[] answers = { true, true, false, true, false };
      bool[] responses = new bool[questions.Length];

      if (questions.Length != answers.Length) {
        Console.WriteLine("Array lengths don't match!");
      }
      int askingIndex = 0;

      // for (int i = 0; i < questions.Length; i++) {
      // }
      Console.WriteLine("Answer True or False to all questions.");
      foreach (string quest in questions) {
        Console.Write(quest + " ");
        string input = Console.ReadLine();
        bool isBool;
        bool inputBool;

        isBool = Boolean.TryParse(input, out inputBool);
        while (!isBool) {
          Console.WriteLine("Please respond with 'true' or 'false'");
          input = Console.ReadLine();
          isBool = Boolean.TryParse(input, out inputBool);
        }
        responses[askingIndex] = inputBool;
        askingIndex++;

      }


    }
  }
}