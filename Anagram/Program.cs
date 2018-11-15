using System;

namespace Anagram.Models
{
  class Program
  {
    public static void Main()
    {

      Console.WriteLine( "Enter a word");
      string inputWord = Console.ReadLine();
      Word newWord = new Word(inputWord);
      Console.WriteLine("Enter few words you think are the Anagram of the actual word");
      Console.WriteLine("Do you want to Add a word [y/n]");
      string yOrN = Console.ReadLine();
      if (yOrN == "y" || yOrN == "Y")
      {
        Console.WriteLine("Please Enter your suggestion");
        string suggestionWord = Console.ReadLine();
        newWord.AddToCompareList(suggestionWord);
        Console.WriteLine("Here is your comparison result");
        char[] outputArr = newWord.CompareWordWithSuggestions();
        foreach (char res in outputArr) {
          Console.WriteLine("\n"+ res);
        }
      }
      else
      {
        Main();
      }

    }
  }
}
