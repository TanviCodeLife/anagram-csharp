using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Anagram.Models
{
  [TestClass]
  public class ItemTest
  {
    // public void Dispose()
    // {
    //   Word.ClearAll();
    // }

    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Word testWord = new Word("test");
      Assert.AreEqual(typeof(Word), testWord.GetType());
    }

    [TestMethod]
    public void Properties_ChecksFirstWordPropertiesInputCorrectly_String()
    {
      //Arrange
      string testWord = "TestListString";
      Word testWordObj = new Word(testWord);

      //Act
      string result = testWordObj.GetFirstWord();

      //Assert
      Assert.AreEqual(testWord, result);
    }

    [TestMethod]
    public void Properties_ChecksInputListPropertyInput_String()
    {
      //Arrange
      List<string> testList = new List<string>{};
      string testInputWord = "TestListString";
      testList.Add(testInputWord);
      Word testWord = new Word(testList);

      //Act
      List<string> listResult = testWord.GetFirstList();

      //Assert
      CollectionAssert.AreEqual(testList, listResult);
    }

    [TestMethod]
    public void Properties_ChecksPropertyInput_String()
    {
      //Arrange
      List<string> testList = new List<string>{};
      string testInputWord = "TestListString";
      testList.Add(testInputWord);
      Word testWord = new Word(testInputWord, testList);

      //Act
      string result = testWord.GetFirstWord();
      List<string> listResult = testWord.GetFirstList();

      //Assert
      Assert.AreEqual(testInputWord, result);
      CollectionAssert.AreEqual(testList, listResult);
    }

    [TestMethod]
    public void AddToCompareList_AddEachUserInputToList_List()
    {
      //Arrange
      List<string> testList = new List<string>{};
      string testInputWord = "TestListString";

      Word testWord = new Word(testInputWord, testList);
      testWord.AddToCompareList(testInputWord);
      testWord.AddToCompareList("SecondItemAdded");

      Word resultWord = new Word(testInputWord, new List<string> (new string[] {"TestListString", "SecondItemAdded"}));

      //Act
      string result = testWord.GetFirstWord();
      List<string> listResult = testWord.GetFirstList();

      foreach (string thisWord in resultWord.GetFirstList())
      {
        Console.WriteLine("Output from resultWord Object compareList: " + thisWord);
      }

      //Assert
      CollectionAssert.AreEqual(testWord.GetFirstList(), resultWord.GetFirstList());
    }



  }
}
