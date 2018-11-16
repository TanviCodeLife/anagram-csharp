using System;
using System.Collections.Generic;

namespace Anagram.Models
{
  public class Word
  {
    private string _firstWord;
    private List<string> _compareList;

    public Word (string firstWord)
    {
      _firstWord = firstWord;
      _compareList = new List<string> {};
    }

    public Word(List<string> compareList)
    {
      _compareList = compareList;
    }

    public Word (string firstWord, List<string> compareList)
    {
      _firstWord = firstWord;
      _compareList = compareList;
    }

    public string GetFirstWord (){
      return _firstWord;
    }

    public List<string> GetFirstList ()
    {
      return _compareList;
    }

    public void AddToCompareList(string word)
    {
      _compareList.Add(word);
    }

    public char[] CompareWordWithSuggestions()
    {
      char[] originalArray = this._firstWord.ToCharArray();
      Array.Sort(originalArray);
      return originalArray;
    }

    public void ParseEachWordInSuggestionList()
    {
      //int listLength = compareList.Count();
      char[] originalWord = this.CompareWordWithSuggestions();
      foreach(string x in this.GetFirstList())
      {
        char[] splitSortedArray = this.CompareWordWithSuggestions();
        if (splitSortedArray.Length == originalWord.Length){
          Console.WriteLine("You have a match in Length");
          int count = 0;
          for(int index = 0; index < myString.Length; index++)
          {
            if(myString[index] == myReverseString[index])
            {
              count++;
            }
          }

          if(count == myString.Length)
          {
            Console.WriteLine(myString + " " + myReverseString + " is a Palindrome");
          }
          else
          {
            Console.WriteLine(myString + " " + myReverseString + " is not a Palindrome");
          }
        } else {
          Console.WriteLine("This word {0} does cannot be an anagram.", x);
        }
      }
    }
  }
}
