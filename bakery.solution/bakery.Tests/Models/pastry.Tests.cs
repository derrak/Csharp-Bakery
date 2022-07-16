using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void Pastry_CreatePastryObject_typePastry()
    {
      //Arrange
      //Act
      Pastry newPastryObj = new Pastry(1, 5);

      //Assert
      Assert.AreEqual(typeof(Pastry), newPastryObj.GetType());
    }

    // [TestMethod]
    // public void Pastry_SingleLoafCost_PastryPrice()
    // {
    //   //Arrange
    //   int price = 5;
    //   Pastry newPastryObj = new Pastry(1, 5);

    //   //Act
    //   int singleLoafPrice = newPastryObj.PastryPrice;

    //   //Assert
    //   Assert.AreEqual(price, singleLoafPrice);
    // }

    // [TestMethod]
    // public void PastryCostCalc_SingleLoafCostCalc_PastryPrice()
    // {
    //   //Arrange
    //   int price = 5;
    //   Pastry newPastryObj = new Pastry(1, 5);

    //   //Act
    //   int pastryTotalCost = newPastryObj.PastryCostCalc();

    //   //Assert
    //   Assert.AreEqual(price, pastryTotalCost);
    // }

    // [TestMethod]
    // public void PastryCostCalc_ThreeLoafCostCalc_2xPastryPrice()
    // {
    //   //Arrange
    //   int price = 5;
    //   Pastry newPastryObj = new Pastry(3, 5);

    //   //Act
    //   int pastryTotalCost = newPastryObj.PastryCostCalc();

    //   //Assert
    //   Assert.AreEqual(price*2, pastryTotalCost);
    // }

    //   [TestMethod]
    // public void PastryCostCalc_ThreeLoafCostCalc_7xPastryPrice()
    // {
    //   //Arrange
    //   int price = 5;
    //   Pastry newPastryObj = new Pastry(7, 5);

    //   //Act
    //   int pastryTotalCost = newPastryObj.PastryCostCalc();

    //   //Assert
    //   Assert.AreEqual((price*4)+price, pastryTotalCost);
    // }
  }
}

