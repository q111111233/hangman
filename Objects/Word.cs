using System.Collections.Generic;

namespace Hangman
{
  public class Word
  {
    private static char[] _letters;
    private static char[] _result;
    private string _word;
    // private int _id;

    public Word(string word)
    {
      _word = word;
      _letters = word.ToCharArray();
      //_result = new char[_letters.Length];

    }
    // public string GetName()
    // {
    //   return _name;
    // }
    // public int GetId()
    // {
    //   return _id;
    // }
    public void SetWord(string newWord)
    {
      _word = newWord;
    }
    public string GetWord()
    {
      return _word;
    }
    public char[] GetLetters()
    {
      return _letters;
    }
    public void SetResult(char[] newResult)
    {
      _result = newResult;
    }
    public char[] GetResult()
    {
      return _result;
    }
    // public void AddArtist(Artist artist)
    // {
    //   _artists.Add(artist);
    // }
    // public static List<Cd> GetAll()
    // {
    //   return _instances;
    // }
    // public static void Clear()
    // {
    //   _instances.Clear();
    // }
    // public static Cd Find(int searchId)
    // {
    //   return _instances[searchId-1];
    // }
  }
}
