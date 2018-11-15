using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Anagram.Models
{
  [TestClass]
  public class ItemTest
  {

    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Word testWord = new Word();
      Assert.AreEqual(typeof(Word), testWord.GetType());
    }
  }
}
