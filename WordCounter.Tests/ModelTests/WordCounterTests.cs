using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.Models;
using System.Collections.Generic;
using WordCounter.Models;

namespace Project.Tests
{
    [TestClass]
    public class WordCounterTester
    {
        [TestMethod]
        public void IsWord_IsTheWordAllLetters_True()
        {
            RepeatCounter newRepeatCounter = new RepeatCounter("fox", "The fox jumps over the lazy brown cows");
            bool result = newRepeatCounter.IsWord();
            Assert.AreEqual(result, true);
        }
        [TestMethod]
        public void IsWord_IsTheWordAllLetters_False()
        {
            RepeatCounter newRepeatCounter = new RepeatCounter("f@x", "The fox jumps over the lazy brown cows");
            bool result = newRepeatCounter.IsWord();
            Assert.AreEqual(result, false);
        }
 
    }
}