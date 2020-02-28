using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int BreadPrice { get; set; }
    public int BreadCount { get; set; }
    public static void BreadPricing()
    {
      Console.WriteLine("Please enter the number of loaves you would like:");
      string breadCount = Console.ReadLine();
      int.Parse(breadCount);
    }
  }
}