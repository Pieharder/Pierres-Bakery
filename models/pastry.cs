using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public static int PPrice { get; set; }
    public static int PCount { get; set; }

    public static void PastryPricing(int Count)
    {
      PCount = Count;
      if (PCount >= 3)
      {
        PPrice = (PCount * 2) - 1;
      }
      else
      {
        PPrice = PCount * 2;
      }
    }
  }
}