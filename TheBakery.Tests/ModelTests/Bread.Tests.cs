using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheBakery.Models;

namespace TheBakery.Tests
{
  [TestClass]
  public class BreadTests
  {

    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_True()   // I'm not 100% sure if this is a valid test of the constructor, but I have 
    {                                                            // but I have to move on.
      int howManyLoaves = 1;                                     // Passing in 1 loaf
      Bread testBread = new Bread(howManyLoaves); 
      Assert.AreEqual(typeof(Bread), testBread.GetType());
    }
    [TestMethod]
    public void TotalBreadCost_CostOfOneLoafWillBe5_True()
    {
      
      Bread testBread = new Bread(1);
      int testCost = testBread.TotalBreadCost();
      int totalCost = 5;
      Assert.AreEqual(totalCost, testCost);
    }
  }
}