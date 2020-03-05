using System.Collections.Generic;

namespace N2w.Models
{
  public class Number
  {
    public string Input { get; set; }

    public Number(string input)
    {
      Input = input;
    }
    public int Convert(string stringNumber)
    {
      int convertedNumber = int.Parse(stringNumber);
      return convertedNumber;
    }
    public string NumberToWords(int number)
    {
      if (number == 0 )
      {
        return "zero";
      }
      return "nothing";
    }
  }
}