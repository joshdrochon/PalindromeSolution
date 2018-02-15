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

      Stack<char> reversedWord = new Stack<char>();

      Stack<char> normalizedWord = new Stack<char>();

      Stack<char> tempReversed = new Stack<char>();

      foreach(char letter in userWord)
      {
        reversedWord.Push(letter);
        tempReversed.Push(letter);
      }

      for(int i = 0; i < userWord.Length; i++)
      {
        char extractedLetter = reversedWord.Pop();
        normalizedWord.Push(extractedLetter);
      }

      string strTempReversed = tempReversed.ToString();
      string strNormWord = normalizedWord.ToString();

      if(strTempReversed.Equals(strNormWord))
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



//Stack.Equals(object)
//Stack.Pop()
//Stack.Push()
