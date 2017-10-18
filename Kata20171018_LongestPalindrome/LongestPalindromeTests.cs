using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20171018_LongestPalindrome
{
    [TestClass]
    public class LongestPalindromeTests
    {
        [TestMethod]
        public void Input_null_string()
        {
            var kata = new Kata();
            var result = kata.GetLongestPalindrome(null);
            Assert.AreEqual(0, result);
        }
        
        [TestMethod]
        public void Input_a_string()
        {
            var kata = new Kata();
            var result = kata.GetLongestPalindrome("a");
            Assert.AreEqual(1, result);
        }
    }

    public class Kata
    {
        public int GetLongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            return 1;
        }
    }
}
