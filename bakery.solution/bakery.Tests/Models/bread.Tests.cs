using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadPricing_NumberDivisibleByThree_True()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(true, testBread.BreadPricing(6));
    }
  }
}