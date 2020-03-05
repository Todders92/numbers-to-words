using System.Collections.Generic;
using System;

namespace N2w.Models
{
  public class Number
  {
    public static Dictionary<int, string> oneThruTwenty = new Dictionary<int, string>() { {0, "zero"}, {1, "one"}, {2, "two"}, {3, "three"}, {4, "four"}, {5, "five"}, {6, "six"}, {7, "seven"}, {8, "eight"}, {9, "nine"}, {10, "ten"}, {11, "eleven"}, {12, "twelve"}, {13, "thirteen"}, {14, "fourteen"}, {15, "fifteen"}, {16, "sixteen"}, {17, "seventeen"}, {18, "eighteen"}, {19, "nineteen"} };
    public static Dictionary<int, string> twentyThruNintety = new Dictionary<int, string>() { {0, "zero"}, {1, "ten"}, {2, "twenty"}, {3, "thirty"}, {4, "forty"}, {5, "fifty"}, {6, "sixty"}, {7, "seventy"}, {8, "eighty"}, {9, "ninety"}, };

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
      string result = "";

      if (number == 0 )
      {
        result = "zero";
        return result;
      }
      if ((number / 1000000) > 0)
        {
          result += NumberToWords(number / 1000000) + " million ";
          number %= 1000000;
        }
      if ((number / 1000) > 0)
        {
          result += NumberToWords(number / 1000) + " thousand ";
          number %= 1000;
        }
      if ((number / 100) > 0)
      { 
        result += NumberToWords(number / 100) + " hundred ";
        number %= 100;
      }
      if (number < 20)
      {
       result += oneThruTwenty[number];
       return result;
      }
      else
      {
        result += twentyThruNintety[number/10];
        if ((number % 10) > 0)
        {
          result += "-" + oneThruTwenty[number%10];
          return result;
        }
      return "nothing yet";
      }
    }
  }
}