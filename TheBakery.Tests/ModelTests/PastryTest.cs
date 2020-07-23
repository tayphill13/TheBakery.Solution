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
      int howManyRolls = 3;
      Pastry testPastry = new Pastry(howManyRolls);
      int testCost = testPastry.TotalPastryCost();
      Assert.AreEqual(5, testCost);
    }
  }
}