namespace Bakery
{
  public class Bread
  {
   int loafPrice = 5;

    public bool BreadPricing(int breadCount)
    {
    // int breadPrice = 0;
    // for(int i = 1; i <= breadCount; i++){
      if (breadCount % 3 == 0)
      {
        return true;
      }
      else{return false;}
    }
    }
  }


/* Buy 2, get 1 free (every 3rd loaf of bread is free.). 
A single loaf costs $5, two loaves costs $10, 
and three loaves cost $10. 


if i%3 == 0 {breadCost+0}
else breadCost + 5;

*/