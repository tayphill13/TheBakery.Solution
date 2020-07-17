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
      Bread testBread = new Bread(1);

      Assert.AreEqual(typeof(Bread), testBread.GetType());
    }
  }
}