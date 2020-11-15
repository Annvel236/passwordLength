using System;

namespace passwordLength
{
  class Program
  {
    static void Main(string[] args)
    {
      int passLength;
      string passChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

      Random random = new Random();

      Console.WriteLine("Enter password length : ");
      passLength = Convert.ToInt32(Console.ReadLine());

      char[] password = new char[passLength];

      for (int i = 0; i < passLength; i++)
      {
        password[i] = passChars[random.Next(passChars.Length)];
      }

      Console.WriteLine(password);
    }
  }
}
