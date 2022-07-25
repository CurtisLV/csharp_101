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
      char[] secretMessage = input.ToCharArray();
      char[] encryptedMessage = new char[secretMessage.Length];

      for (int i = 0; i < secretMessage.Length; i++) {
       char letter = secretMessage[i];
       int indexAlphabet = Array.IndexOf(alphabet, letter);
          // if (indexAlphabet + 3 > alphabet.Length) {
          //   indexAlphabet = indexAlphabet + 3 - alphabet.Length;
          // } else {
          //   indexAlphabet += 3;
          //   encryptedMessage[i] = alphabet[indexAlphabet];
          // }
          indexAlphabet = (indexAlphabet + 3) % 26;
          encryptedMessage[i] = alphabet[indexAlphabet];

          Console.WriteLine(letter + ", " + alphabet[indexAlphabet] + ", " + encryptedMessage[i]);
       }
      string finalEncryptedMsg = String.Join("", encryptedMessage);
      Console.WriteLine(finalEncryptedMsg);
    }
  }
}