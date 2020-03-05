using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using N2w.Models;
using System;

namespace N2w.TestTools
{
  [TestClass]
  public class N2wTests
  {
    [TestMethod]
    public void Number_CheckForStringInput_String()
    {
      string input = "400";
      Number newNumber = new Number(input);
      Assert.AreEqual(typeof(Number), newNumber.GetType()); 
    }

  }
}