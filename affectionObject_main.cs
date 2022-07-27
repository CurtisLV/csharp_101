using System;

namespace DatingProfile
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] hobbies = {
        "listening to audiobooks and podcasts",
        "playing rec sports like bowling and kickball",
        "writing a speculative fiction novel",
        "reading advice columns"
      };
      
      Profile sam = new Profile("Sam Dracula", 30, "New York", "USA", "he/him");
      sam.SetHobbies(hobbies);
      Console.WriteLine(sam.ViewProfile());
    }
  }
}

