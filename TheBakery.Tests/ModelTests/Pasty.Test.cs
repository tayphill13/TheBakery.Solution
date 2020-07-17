using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheBakery.Models;

namespace TheBakery.Tests
{
  [TestClass]
  public class Pastries
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_True()   
    {                                                            
      int howManyRolls = 1;                                     
      Pastry testPastry = new Pastry(howManyRolls);
      Assert.AreEqual(typeof(Pastry), testPastry.GetType());
    }//Arrange
    //Act
    //Assert.AreEqual(ExpectedResult, Code_To_Test);
  }
}