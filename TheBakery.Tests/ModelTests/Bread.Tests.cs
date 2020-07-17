using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheBakery.Models;

namespace TheBakery.Tests
{
  [TestClass]
  public class BreadTests
  {

    [TestMethod]
    public void Bread_ConfirmPriceForLoafIs5_True()
    {
      Bread testBread = new Bread();
      int CostPerLoaf = 5;

      bool NTest = Bread(CostPerLoaf);

      Assert.AreEqual(true, NTest);
    }
  }
}