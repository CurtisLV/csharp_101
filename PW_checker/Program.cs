using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {

    int minLength = 8;
    string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; 
    string lowerCase = "abcdefghijklmnopqrstuvwxyz";
    string digits = "0123456789";
    string specialChars = "!@#$%^&*()";

    Console.WriteLine("Please input password: ");
    string input = Console.ReadLine();

    int score = 0;

    if (input.Length >= minLength) {
      score++;
    };
    if (Tools.Contains(input, upperCase)) {
      score++;
    }
    if (Tools.Contains(input, lowerCase)) {
      score++;
    }
    if (Tools.Contains(input, digits)) {
      score++;
    }
    if (Tools.Contains(input, specialChars)) {
      score++;
    }
    if (input == "password" || input == "1234"){
      score = 0;
    }
   
   switch (score) {
      case 5:
        Console.WriteLine($"Your PW scores a {score}. Extremely strong!");
        break;
      case 4:
        Console.WriteLine($"Your PW scores a {score}. Extremely strong!");
        break;
      case 3:
        Console.WriteLine("Your PW scores a 3. Strong.");
        break;
      case 2:
        Console.WriteLine("Your PW scores a 2. Medium.");
        break;
      case 1:
        Console.WriteLine("Your PW scores a 1. Weak.");
        break;
      default:
        Console.WriteLine("Your PW scores zero! Bad... Disappointing...");
        break;
   }

    }
  }
}