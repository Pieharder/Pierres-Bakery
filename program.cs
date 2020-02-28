using System;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's World Class Bakery!");
      Console.WriteLine("Today we have Fresh baked loaves of bread for a mere price of $5! We also have yummy pastries for $2!");
      Console.WriteLine("Today's specials are buy 2 get 1 free on bread as well as 3 pastries for $5!");
      Console.WriteLine("Please Enter which you would like to buy:");
      Console.WriteLine("[BREAD] [PASTRY]");
      string productChoice = Console.ReadLine();
    }
  }
}