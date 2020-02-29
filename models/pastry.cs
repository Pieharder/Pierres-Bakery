using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public int PPrice { get; set; }
    public int PCount { get; set; }

    public static void PastryPricing(int pastryCount)
    {
      if (pastryCount == 3)
      {
        int pastryFinal = (pastryCount * 2) - 1;
      }
      else
      {
        int pastryFinal = pastryCount * 2;
      }
    }
  }
}