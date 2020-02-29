using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int BPrice { get; set; }
    public int BCount { get; set; }
    public static void BreadPricing(int breadCount)
    {
      if (breadCount == 3)
      {
        int breadFinal = (breadCount * 2) - 1;
      }
      else
      {
        int breadFinal = breadCount * 2;
      }
    }
  }
}