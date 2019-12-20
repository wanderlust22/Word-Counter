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
      return false;
    }

    public bool IsSentence()
    {
      return false;
    }
  }
}