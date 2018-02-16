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
      //Arrange
      Palindrome testPalindromeTrue = new Palindrome();
      //Act
      bool expectedTrue = testPalindromeTrue.PaliCalc("racecar");
      //Assert
      Assert.AreEqual(true, expectedTrue);
    }

    [TestMethod]
    public void TestIsPalindrome_False()
    {
      //Arrange
      Palindrome testPalindromeFalse = new Palindrome();
      //Act
      bool expectedFalse = testPalindromeFalse.PaliCalc("random");
      //Assert
      Assert.AreEqual(false, expectedFalse);
    }
  }
}
