using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeProject.Models;
using PalindromeProject;
using System;

namespace PalindromeProject.Test
{
  [TestClass]
  public class PalindromeTest
  {
    [TestMethod]
    public void TestIsPalindrome_True()
    {
      Palindrome testPalindromeTrue = new Palindrome();
      Assert.AreEqual(false, testPalindromeTrue.PaliCalc("racecar"));
    }

    [TestMethod]
    public void TestIsPalindrome_False()
    {
      Palindrome testPalindromeFalse = new Palindrome();
      Assert.AreEqual(true, testPalindromeFalse.PaliCalc("random"));
    }
  }
}
