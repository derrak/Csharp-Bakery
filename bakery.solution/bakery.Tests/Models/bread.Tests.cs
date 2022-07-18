using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

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
      Bread newBreadObj = new Bread(1, 5);

      //Assert
      Assert.AreEqual(typeof(Bread), newBreadObj.GetType());
    }

    [TestMethod]
    public void Bread_SingleLoafCost_BreadPrice()
    {
      //Arrange
      int price = 5;
      Bread newBreadObj = new Bread(1, 5);

      //Act
      int singleLoafPrice = newBreadObj.BreadPrice;

      //Assert
      Assert.AreEqual(price, singleLoafPrice);
    }

    [TestMethod]
    public void BreadCostCalc_SingleLoafCostCalc_BreadPrice()
    {
      //Arrange
      int price = 5;
      Bread newBreadObj = new Bread(1, 5);

      //Act
      int breadTotalCost = newBreadObj.BreadCostCalc();

      //Assert
      Assert.AreEqual(price, breadTotalCost);
    }

    [TestMethod]
    public void BreadCostCalc_ThreeLoafCostCalc_2xBreadPrice()
    {
      //Arrange
      int price = 5;
      Bread newBreadObj = new Bread(3, 5);

      //Act
      int breadTotalCost = newBreadObj.BreadCostCalc();

      //Assert
      Assert.AreEqual(price*2, breadTotalCost);
    }

      [TestMethod]
    public void BreadCostCalc_ThreeLoafCostCalc_7xBreadPrice()
    {
      //Arrange
      int price = 5;
      Bread newBreadObj = new Bread(7, 5);

      //Act
      int breadTotalCost = newBreadObj.BreadCostCalc();

      //Assert
      Assert.AreEqual((price*4)+price, breadTotalCost);
    }
  }
}

