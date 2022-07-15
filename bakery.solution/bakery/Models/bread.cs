using System;

namespace Bakery
{
  public class Bread
  {
    public int LoafOrderCount {get;set;}
    public int LoafPrice {get;set;}
    public int BreadOrderPrice {get;set;}

    public Bread(int loafOrderCount, int loafPrice)
    {
      LoafOrderCount = loafOrderCount;
      LoafPrice = 5;
    }

    public void BreadPricing()
    {
      int breadPrice = 0;

      for (int i = 1; i <= LoafOrderCount; i++)
      {
        if (i % 3 == 0)
        {
          breadPrice += 0;
        }
        else
        {
          breadPrice += LoafPrice;
        }
      }
      BreadOrderPrice = breadPrice;
    }
  }
}



/* Buy 2, get 1 free (every 3rd loaf of bread is free.). 
A single loaf costs $5, two loaves costs $10, 
and three loaves cost $10. 


if i%3 == 0 {breadCost+0}
else breadCost + 5;

*/