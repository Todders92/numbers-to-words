using System;
using System.Collections.Generic;
using N2w.Models;

namespace Program
{
  public class N2w
  {
    public static void Main()
    {
      Console.WriteLine("punch in a number and we will spell it out for you");
      string stringNumber = Console.ReadLine();
      Number newNumber = new Number(stringNumber);
      long inputNumber = newNumber.Convert(newNumber.Input);
      Console.WriteLine(newNumber.NumberToWords(inputNumber));
    }
  }
}