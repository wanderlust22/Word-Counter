using System;
using System.Collections.Generic;
using System.Threading;
using WordCounter.Models;


  public class Program{
    static void Main()
    {
      Console.WriteLine("Welcome! This is a word counter program in which a person is able to submit a word and a setence and is told how many times the word occurs in the sentence.");
      Thread.Sleep(2000);
      Console.WriteLine("So first, enter a sentence you'd like to evaluate.");
      string theSentence = Console.ReadLine();
    }
  }
