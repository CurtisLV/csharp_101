using System;

namespace Review
{
  class Program
  {
    static void Main(string[] args)
    {
      /* use this space to write your own short program! 
      Here's what you learned:

      CONDITIONALS: if, if...else, else if
      SWITCH STATEMENT: switch (condition)
      TERNARY OPERATOR: (condition) ? true : false

      Good luck! */
      
      // Has a user guess a random number between 1-10 and lets them know if they got it correct, are too low, or are too high
      Random rand = new Random();
      int rnd = rand.Next(1, 10);

      Console.WriteLine("Please enter a random number from 1-10:");
      int answer = Convert.ToInt32(Console.ReadLine());

      if (rnd < answer) {
         Console.WriteLine($"You should guess lower than {answer}!");
      } else if (rnd > answer) {
        Console.WriteLine($"You should guess higher than {answer}!");
      } else {
        Console.WriteLine($"Congratz! The number {rnd} is equal to {answer}!");
      }

    }
  }
}
