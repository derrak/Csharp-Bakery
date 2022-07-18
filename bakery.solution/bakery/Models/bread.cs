using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int BreadPrice { get; set; }
    public int BreadQuantity { get; set; }
    public int BreadOrderTotal { get; set; }

    //Constructor
    public Bread(int breadQuantity, int breadPrice)
    {
      BreadQuantity = breadQuantity;
      BreadPrice = breadPrice;
      BreadOrderTotal = 0;
    }

    //Methods
    public int BreadCostCalc()
    {
      if (BreadQuantity > 2)
      {
        BreadOrderTotal = (BreadQuantity * BreadPrice) - (BreadQuantity / 3 * BreadPrice);
        return BreadOrderTotal;
      }
      else
      {
        BreadOrderTotal = BreadQuantity * BreadPrice;
        return BreadOrderTotal;
      }
    }
  }
}