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
      // string userWord = "word";

      Stack<char> reversedWord = new Stack<char>();

	    string result = "";

      foreach(char character in userWord)
      {
        reversedWord.Push(character);
      }

      //reversedWord = {"d" "o" "r" "w"}

      for(int i = 0; i < userWord.Length; i++)
      {
        char extractedChar = reversedWord.Pop();
        //pops d
        //pops o
		    result += extractedChar;
        //result = "d"
        //result = "d" + "o"
        //result = "do" + "r"
        //result = "dor" + "w"
        //result = "dorw"
      }

      if(result.Equals(userWord))
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
