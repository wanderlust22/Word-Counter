using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            RepeatCounter newRepeatCounter = new RepeatCounter("fox", "The fox jumps over the lazy brown cow.");
            bool result = newRepeatCounter.IsWord();
            Assert.AreEqual(result, true);
        }
        [TestMethod]
        public void IsWord_IsTheWordAllLettersIfSymbol_False()
        {
            RepeatCounter newRepeatCounter = new RepeatCounter("f@x", "The fox jumps over the lazy brown cow.");
            bool result = newRepeatCounter.IsWord();
            Assert.AreEqual(result, false);
        }
        [TestMethod]
        public void IsWord_IsTheWordAllLettersIfUppercased_True()
        {
            RepeatCounter newRepeatCounter = new RepeatCounter("fOx", "The fox jumps over the lazy brown cow.");
            bool result = newRepeatCounter.IsWord();
            Assert.AreEqual(result, true);
        }
        [TestMethod]
        public void IsSentence_DoesTheSentenceBeginWithUpperCaseLetter_True()
        {
            RepeatCounter newRepeatCounter = new RepeatCounter("fOx", "The fox jumps over the lazy brown cow.");
            bool result = newRepeatCounter.IsSentence();
            Assert.AreEqual(result, true);
        }
        [TestMethod]
        public void IsSentence_DoesTheSentenceBeginWithUpperCaseLetter_False()
        {
            RepeatCounter newRepeatCounter = new RepeatCounter("fOx", "the fox jumps over the lazy brown cow.");
            bool result = newRepeatCounter.IsSentence();
            Assert.AreEqual(result, false);
        }
        [TestMethod]
        public void IsSentence_DoesTheSentenceEndWithPunctuation_True()
        {
            RepeatCounter newRepeatCounter = new RepeatCounter("fox", "The fox jumps over the lazy brown cow.");
            bool result = newRepeatCounter.IsSentence();
            Assert.AreEqual(result, true);
        }
        [TestMethod]
        public void IsSentence_DoesTheSentenceEndWithPunctuation_False()
        {
            RepeatCounter newRepeatCounter = new RepeatCounter("fox", "The fox jumps over the lazy brown cow");
            bool result = newRepeatCounter.IsSentence();
            Assert.AreEqual(result, false);
        }
        [TestMethod]
        public void WordCount_HowManyTimesDoesTheSentenceContainTheWord_One()
        {
            RepeatCounter newRepeatCounter = new RepeatCounter("fox", "The fox jumps over the lazy brown cow.");
            int result = newRepeatCounter.WordCount();
            Assert.AreEqual(result, 1);
        }
        [TestMethod]
        public void WordCount_HowManyTimesDoesTheSentenceContainTheWordWhenWordIsWonky_One()
        {
            RepeatCounter newRepeatCounter = new RepeatCounter("fox", "The foX; jumps over the lazy brown cow.");
            int result = newRepeatCounter.WordCount();
            Assert.AreEqual(result, 1);
        }
        [TestMethod]
        public void WordCount_HowManyTimesDoesTheSentenceContainTheWord_Two()
        {
            RepeatCounter newRepeatCounter = new RepeatCounter("fox", "The fox jumps over the lazy brown fox.");
            int result = newRepeatCounter.WordCount();
            Assert.AreEqual(result, 2);
        }
 
 
    }
}