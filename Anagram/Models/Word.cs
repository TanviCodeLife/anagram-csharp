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
  }
}
