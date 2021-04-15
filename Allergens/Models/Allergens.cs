using System;
using System.Collections.Generic;

namespace Allergens.Models
{
  public class AllergenScore
  {
    public static List<string> allergenScore(int input)
    {
        string binary = Convert.ToString(input, 2);
        char[] digits = binary.ToCharArray();
        Array.Reverse(digits);
        List<string> allergenList = new List<string>();
        if(digits.Length >= 1 && digits[0] == '1') {
          allergenList.Add("eggs");
        }
        if(digits.Length >= 2 && digits[1] == '1') {
         allergenList.Add("peanuts");
        }
        if(digits.Length >= 3 && digits[2] == '1') {
         allergenList.Add("shellfish");
        }
        if(digits.Length >= 4 && digits[3] == '1') {
         allergenList.Add("strawberries");
        }
        if(digits.Length >= 5 && digits[4] == '1') {
         allergenList.Add("tomatoes");
        }
        if(digits.Length >= 6 && digits[5] == '1') {
         allergenList.Add("chocolate");
        }
        if(digits.Length >= 7 && digits[6] == '1') {
         allergenList.Add("pollen");
        }
        if(digits.Length >= 8 && digits[7] == '1') {
         allergenList.Add("cats");
        }
        return allergenList;
    }
  }
}

