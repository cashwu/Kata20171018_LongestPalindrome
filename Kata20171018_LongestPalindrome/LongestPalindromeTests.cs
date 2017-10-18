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
    }

    public class Kata
    {
        public int GetLongestPalindrome(string s)
        {
            return 0;
        }
    }
}
