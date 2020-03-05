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
    [TestMethod]
    public void Convert_ConfirmInputStringToNumber_Int()
    {
      string input = "400";
      Number newNumber = new Number(input);
      int converted = newNumber.Convert(newNumber.Input);
      Assert.AreEqual(400, converted);
    }
    [TestMethod]
    public void NumberToWords_CheckForInput0_String()
    {
      string input = "0";
      Number newNumber = new Number(input);
      int converted = newNumber.Convert(newNumber.Input);
      string numberToWords = newNumber.NumberToWords(converted);
      Assert.AreEqual("zero", numberToWords);
    }
    [TestMethod]
    public void NumberToWords_CheckForInputUnder20_String()
    {
      string input = "17";
      Number newNumber = new Number(input);
      int converted = newNumber.Convert(newNumber.Input);
      string numberToWords = newNumber.NumberToWords(converted);
      Assert.AreEqual("seventeen", numberToWords);
    }
    [TestMethod]
    public void NumberToWords_CheckForInputUnder100ButOver20_String()
    {
      string input = "48";
      Number newNumber = new Number(input);
      int converted = newNumber.Convert(newNumber.Input);
      string numberToWords = newNumber.NumberToWords(converted);
      Assert.AreEqual("forty-eight", numberToWords);
    }
  }
}