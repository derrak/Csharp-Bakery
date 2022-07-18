using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryPrice;
    public int PastryQuantity;
    public int PastryOrderTotal {get; set;}

    public Pastry(int pastryQuantity, int pastryPrice)
    {
      PastryQuantity = pastryQuantity;
      PastryPrice = pastryPrice;
      PastryOrderTotal = 0;
    }

    public int PastryCostCalc()
    {
      if (PastryQuantity > 2)
      {
        PastryOrderTotal = (PastryQuantity * PastryPrice) - (PastryQuantity / 3 * PastryPrice);
        return PastryOrderTotal;
      }
      else
      {
        PastryOrderTotal = PastryQuantity * PastryPrice;
        return PastryOrderTotal;
      }
    }
  }
}