using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public int Price { get; set; }
    public int Count { get; set; }

    public static void PastryPrice(int pastryCount)
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