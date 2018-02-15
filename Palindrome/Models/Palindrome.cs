using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace PalindromeProject.Models
{
  public class Palindrome
  {
    public bool PaliCalc(string word)
    {

      string userWord = word;
      // string userWord = "random";

      Stack<char> reversedWord = new Stack<char>();

      Stack<char> normalizedWord = new Stack<char>();

      Stack<char> tempReversed = new Stack<char>();

      foreach(char character in userWord)
      {
        reversedWord.Push(character);
        tempReversed.Push(character);
      }

      for(int i = 0; i < userWord.Length; i++)
      {
        char extractedChar = reversedWord.Pop();
        normalizedWord.Push(extractedChar);
      }

      string strTempReversed = tempReversed.ToString();
      string strNormalizedWord = normalizedWord.ToString();

      if(strTempReversed == strNormalizedWord)
      {
        return true;
      }
      else
      {
        return false;
      }

    }
  }
}
