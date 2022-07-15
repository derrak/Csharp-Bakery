using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    // [TestMethod]
    // public void BreadPricing_NumberDivisibleByThree_True()
    // {
    //   Bread testBread = new Bread();
    //   Assert.AreEqual(true, testBread.BreadPricing(6));
    // }
    [TestMethod]
    public void BreadPricing_PriceOneLaof_loafPrice()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(5, testBread.BreadPricing(1,5));
    }

    [TestMethod]
    public void BreadPricing_PriceOneLaof_2xloafPrice()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(10, testBread.BreadPricing(2,5));
    }
  }
}