using System;

class Program
{
  static void Main(string[] args)
  {
    while (true)
    {
      Console.Clear();
      Console.WriteLine("🚀 CSharp-Kern - Algorithm Runner");
      Console.WriteLine("1️⃣  - Reverse String");
      Console.WriteLine("2️⃣  - First Unique Character in a String");
      Console.WriteLine("3️⃣  - Exit");
      Console.Write("Choose an algorithm: ");

      string choice = Console.ReadLine();
      Console.Clear();

      switch (choice)
      {
        case "1":
          ReverseString.Run();
          break;
        case "2":
          FirstUniqueCharacter.Run();
          break;
        case "3":
          return;
        default:
          Console.WriteLine("🛑 Invalid option. Try again.");
          Console.ReadKey();
          break;
      }
    }
  }
}