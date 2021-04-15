using System;
using System.Collections.Generic;
using Allergens.Models;

namespace Allergens
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Type in your allergen score:");
      string userInput = System.Console.ReadLine();
      int input = int.Parse(userInput);
      List<string> allergyList = AllergenScore.allergenScore(input); 
       foreach (string item in allergyList)
        {
            Console.WriteLine(item);
        }
    }
  }
}