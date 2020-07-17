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
      Bread testBread = new Bread(1);                            // Passing in 1 loaf
      Assert.AreEqual(typeof(Bread), testBread.GetType());
    }
    [TestMethod]
    public void MethodToTest_WhatImTestingFor_ExpectedOutput()
    {
      Bread testBread = new Bread();
    }
  }
}