
namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public string Word { get; set;}
    public string Sentence { get; set; }

    public RepeatCounter(string sentence)
    {
      Sentence = sentence;
    }
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
        if ( !abc.Contains(lowercase[i]) )
        {
          return false;
        }
      }
      return true;
    }

    public bool IsSentence()
    {
      if (this.IsUpperCased() && this.IsPuncuated())
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public bool IsUpperCased()
    {
      string[] sentenceArr = Sentence.Split(" ");
      string firstWord = sentenceArr[0];
      string firstUpper = firstWord.ToUpper();

      if ( firstWord[0] == firstUpper[0] )
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public bool IsPuncuated()
    {
      string[] sentenceArr = Sentence.Split(" ");
      int length = sentenceArr.Length;
      string lastWord = sentenceArr[length - 1];
      int lastWordLength = lastWord.Length;
      string marks = ".!?";

      if ( marks.Contains(lastWord[lastWordLength - 1]) )
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public int WordCount()
    {
      int count = 0;
      string sentenceLowered = Sentence.ToLower();
      string wordLowered = Word.ToLower();
      string[] sentenceArr = sentenceLowered.Split(" ");
      for ( int i = 0; i < sentenceArr.Length; i++ )
      {
        if ( sentenceArr[i] == wordLowered || sentenceArr[i] == wordLowered + "," || sentenceArr[i] == wordLowered + "." || sentenceArr[i] == wordLowered + "!" || sentenceArr[i] == wordLowered + "?" || sentenceArr[i] == wordLowered + ";" || sentenceArr[i] == wordLowered + ":")
        {
          count++;
        }
      }
      return count;
    }
  }
}