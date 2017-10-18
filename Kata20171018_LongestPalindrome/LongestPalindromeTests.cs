using System;
using System.Linq;
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
        
        [TestMethod]
        public void Input_ab_string()
        {
            var kata = new Kata();
            var result = kata.GetLongestPalindrome("aa");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Input_aba_string()
        {
            var kata = new Kata();
            var result = kata.GetLongestPalindrome("aba");
            Assert.AreEqual(3, result);
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

            if (s == string.Concat(s.Reverse()))
            {
                return s.Length;
            }

            return 1;
        }
    }
}
