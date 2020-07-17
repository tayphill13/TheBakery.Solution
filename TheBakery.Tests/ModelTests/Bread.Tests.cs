using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheBakery.Models;

namespace TheBakery.Tests
{
  [TestClass]
  public class BreadTests
  {

    [TestMethod]
    public void BreadConstructor_ConfirmPriceFor1LoafIs5_True()
    {
      Bread testBread = new Bread(1);
      int CostPerLoaf = 5;

      bool NTest = Bread(1);

      Assert.AreEqual(5, NTest);
    }
  }
}