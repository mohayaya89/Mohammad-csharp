using System;
using Palindrome.Library.Abstract;


namespace Palindrome.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPolindrome();
        }


        private static void MyPolindrome()
    {
      var exit = false;
      string input = string.Empty;

      System.Console.WriteLine("welcome to my polindrome");
      
      do
      {
        System.Console.WriteLine("(1) create | (2) read ");
        Console.Write("enter action number: ");
        input = Console.ReadLine();

        switch (input)
        {
          case "1":
            CreatePalindrom(new word());
            break;
          case "2":
            Console.WriteLine(ReadPalindrome());
            break;
          case "3":
            exit = true;
            break;
        }
      } while(!exit);
      
    }
    }
}
