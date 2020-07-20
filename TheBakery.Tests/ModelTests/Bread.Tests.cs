using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheBakery.Models;

namespace TheBakery.Tests
{
  [TestClass]
  public class BreadTests
  {

    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_True()
    {
      int howManyLoaves = 1;           
      Bread testBread = new Bread(howManyLoaves); 
      Assert.AreEqual(typeof(Bread), testBread.GetType());
    }
    [TestMethod]
    public void TotalBreadCost_CostOfTwoLoavesWillBe10_True()
    {
      Bread testBread = new Bread(2);
      int testCost = testBread.TotalBreadCost();
      Assert.AreEqual(10, testCost);
    }
    [TestMethod]
    public void TotalBreadCost_SpecialsCostOf6LoavesWillBe20_True()
    {
      Bread testBread = new Bread(6);
      int testCost = testBread.TotalBreadCost();
      Assert.AreEqual(20, testCost);
    }
    [TestMethod]
    public void TotalBreadCost_CostOf4LoavesIs15_True()
    {
      Bread testBread = new Bread(4);
      int testCost = testBread.TotalBreadCost();
      Assert.AreEqual(15, testCost);
    }
    [TestMethod]
    public void TotalBreadCost_CostOf8LoavesWillBe30_True()
    {
      Bread testBread = new Bread(8);
      int testCost = testBread.TotalBreadCost();
      Assert.AreEqual(30, testCost);
    }
  }
}