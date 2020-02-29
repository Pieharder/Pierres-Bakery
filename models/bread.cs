namespace Bakery.Models
{
  public class Bread
  {
    public static int BPrice { get; set; }
    public static int BCount { get; set; }
    public static void BreadPricing(int Count)
    {
      BCount = Count;

      if (BCount >= 3)
      {
        BPrice = (BCount * 5) - 5;
      }
      else
      {
        BPrice = BCount * 5;
      }
    }
  }
}