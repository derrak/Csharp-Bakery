using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void Bread_CreateBreadObject_typeBread()
    {
      //Arrange
      //Act
      Bread newBreadObj = new Bread(1,5);

      //Assert
      Assert.AreEqual(typeof(Bread), newBreadObj.GetType());
    }

        [TestMethod]
    public void Bread_SingleLoafCost_BreadPrice()
    {
      //Arrange
      int price = 5;
      Bread newBreadObj = new Bread(1,5);

      //Act
      int singleLoafPrice = newBreadObj.BreadPrice;

      //Assert
      Assert.AreEqual(price, singleLoafPrice);
    }
  }
}