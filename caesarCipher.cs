using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      
      Console.Write("Please enter a secret message: ");
      string input = Console.ReadLine();
      input = input.ToLower();
      char[] secretMessage = input.ToCharArray();
      char[] encryptedMessage = new char[secretMessage.Length];

      for (int i = 0; i < secretMessage.Length; i++) {
        char letter = secretMessage[i];
        int indexAlphabet = Array.IndexOf(alphabet, letter);
        indexAlphabet = (indexAlphabet + 3) % 26;
        encryptedMessage[i] = alphabet[indexAlphabet];
       }
      string finalEncryptedMsg = String.Join("", encryptedMessage);
      Console.WriteLine(finalEncryptedMsg);
    }
  }
}