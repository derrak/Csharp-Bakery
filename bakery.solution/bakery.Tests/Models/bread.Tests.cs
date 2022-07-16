using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bread1.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void Bread_CreateBreadObject_typeBread()
    {
      //Arrange
      //Act
      Bread newBreadObj = new Bread();

      //Assert
      Assert.AreEqual(typeof(Bread), newBreadObj.GetType());
    }
  }
}