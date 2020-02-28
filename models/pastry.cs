using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public int Price { get; set; }
    public int Count { get; set; }

    public Pastry()
    {
      Price = 5;
    }
    public static void PastryPricing()
    {
      Console.WriteLine("Please enter the number of loaves you would like:");
      string breadCount = Console.ReadLine();
      int.Parse(breadCount);
    }
  }
}