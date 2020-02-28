using System;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.Clear();
      Console.WriteLine("Welcome to Pierre's World Class Bakery!");
      Console.WriteLine("Today we have Fresh baked loaves of bread for a mere price of $5! We also have yummy pastries for $2!");
      Console.WriteLine("Today's specials are buy 2 get 1 free on bread as well as 3 pastries for $5!*");
      Console.WriteLine("*Promotion pricing is limit, to one promo per customer.");
      Console.WriteLine("Would you like to shop?");
      Console.WriteLine("[SHOP] [EXIT]");
      string shopStatus = Console.ReadLine();
      
      if (shopStatus.ToLower() == "shop")
      {
        Shop();
      }
      else if (shopStatus.ToLower() == "exit")
      {
        Console.WriteLine("Have a wonderful day and come see us again soon!");
      }
      else
      {
        Main();
      }
    }

    public static void Shop()
    {
      Console.WriteLine("Please Enter which you would like to buy:");
      Console.WriteLine("[BREAD] [PASTRY]");
      string productChoice = Console.ReadLine();
      
      if (productChoice.ToLower() == "bread")
      {
        Bread.BreadPricing();
        ReturnMenu();
      }
      else if (productChoice.ToLower() == "pastry")
      {
        Pastry.PastryInput();
        ReturnMenu();
      }
      else
      {
        Shop();
      }
    }

    public static void ReturnMenu()
    {
      Console.WriteLine("Would you like to purchase anything else?");
      Console.WriteLine("[YES] [NO]");
      string backToMenu = Console.ReadLine();
    }

    public static void Checkout()
    {
      Pastry.PastryPrice();
      Console.WriteLine("Your total today is:");
      
    }
  }
}