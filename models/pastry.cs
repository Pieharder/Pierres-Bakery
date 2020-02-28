using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public int Price { get; set; }
    public int Count { get; set; }

    public Pastry()
    {
      Price = 2;
    }
    public static void PastryPricing()
    {
      Console.WriteLine("Please enter the number of pastries you would like:");
      string pastryCount = Console.ReadLine();
      int.Parse(pastryCount);
    }
  }
}