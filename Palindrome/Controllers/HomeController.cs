using Microsoft.AspNetCore.Mvc;
using PalindromeProject.Models;
using System;

namespace PalindromeProject.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("Palindome/PalindromeResult")]
    public ActionResult Result()
    {
      string userInput = Request.Form["user-input"];

      Palindrome newPalindrome = new Palindrome();

      bool myPalindrome = newPalindrome.PaliCalc(userInput);

      if(myPalindrome == true)
      {
        return View("../Palindrome/ResultTrue");
      }
      else
      {
        return View("../Palindrome/ResultFalse");
      }
    }
  }
}
