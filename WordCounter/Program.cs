using System;
using System.Threading;
using WordCounter.Models;


  public class Program{
    static void Main()
    {
      Console.WriteLine("Welcome! This is a word counter program in which a person is able to submit a word and a sentence and is told how many times the word occurs in the sentence.");
      Thread.Sleep(2000);
      Console.WriteLine("So first, enter a sentence you'd like to evaluate.");
      string theSentence = Console.ReadLine();
      RepeatCounter justSentence = new RepeatCounter(theSentence);
      bool toContinue = justSentence.IsSentence();
      
      if ( !toContinue )
      {
        Console.WriteLine("Sorry that's not a proper sentence. Restart the program and try again.");
        return;
      }

      Console.WriteLine("Great! Now please enter the word you'd like to check whether it is in your sentence or not.");
      string theWord = Console.ReadLine();
      RepeatCounter sentenceAndWord = new RepeatCounter(theWord, theSentence);
      bool toBeContinued = sentenceAndWord.IsWord();

      if ( !toBeContinued )
      {
        Console.WriteLine("Sorry that's not a proper word. Restart the program and try again.");
        return;
      }

      int wordCount = sentenceAndWord.WordCount();
      Console.WriteLine("The word you entered occurs in the sentence you entered " + wordCount + " times.");




    }
  }
