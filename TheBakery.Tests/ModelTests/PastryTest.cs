using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheBakery.Models;

namespace TheBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_True()   
    {                                                            
      int howManyRolls = 1;                                     
      Pastry testPastry = new Pastry(howManyRolls);
      Assert.AreEqual(typeof(Pastry), testPastry.GetType());
    }
    [TestMethod]
    public void TotalPastryCost_CostOfOneRollIs2_True()
    {
      int howManyRolls = 1;
      Pastry testPastry = new Pastry(howManyRolls);
      int testCost = testPastry.TotalPastryCost();
      Assert.AreEqual(2, testCost);
    }
    [TestMethod]
    public void TotalPastryCost_CostOf4RollsIs7_True()
    {
      int howManyRolls = 4;
      Pastry testPastry = new Pastry(howManyRolls);
      int testCost = testPastry.TotalPastryCost();
      Assert.AreEqual(7, testCost);
    }
    [TestMethod]
    public void TotalPastryCost_CostOf10RollsShouldBe17_True()
    {
      int howManyRolls = 10;
      Pastry testPastry = new Pastry(howManyRolls);
      int testCost = testPastry.TotalPastryCost();
      Assert.AreEqual(17, testCost); 
    }
    [TestMethod]
    public void TotalPastryCost_CostOf40RollsShouldBe67_True()
    {
      int howManyRolls = 40;
      Pastry testPastry = new Pastry(howManyRolls);
      int testCost = testPastry.TotalPastryCost();
      Assert.AreEqual(67, testCost);
    }
  }
}