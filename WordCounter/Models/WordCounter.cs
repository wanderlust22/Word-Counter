using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public string Word { get; set;}
    public string Sentence { get; set; }
    public RepeatCounter(string word, string sentence)
    {
      Word = word;
      Sentence = sentence;
    }

    public bool IsWord()
    {
      string abc = "abcdefghijklmnopqrstuvwxyz";
      string lowercase = Word.ToLower();

      for (int i = 0; i < Word.Length; i++)
      {
        if ( !abc.Contains(Word[i]) )
        {
          return false;
        }
      }
      return true;
    }

    public bool IsSentence()
    {
      return false;
    }
  }
}