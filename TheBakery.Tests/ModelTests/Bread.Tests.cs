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
    public void TotalBreadCost_TotalCostWillBeReturnedFor2BreadLoaves_True()
    {
      Bread testBread = new Bread();
      int howManyLoaves = 2;
      int testCost = testBread.TotalBreadCost(howManyLoaves);
      int totalCost = 10;
      Assert.AreEqual(totalCost, testCost);
    }
  }
}