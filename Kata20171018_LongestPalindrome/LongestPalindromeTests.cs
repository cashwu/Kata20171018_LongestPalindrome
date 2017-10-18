using System.Collections.Generic;
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

        [TestMethod]
        public void Input_aab_string()
        {
            var kata = new Kata();
            var result = kata.GetLongestPalindrome("aab");
            Assert.AreEqual(2, result);
        }
    }

    public class Kata
    {
        public int GetLongestPalindrome(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            var reverseStr = string.Concat(str.Reverse());
            if (str == reverseStr)
            {
                return str.Length;
            }

            var s = string.Concat(str.Take(str.Length - 1));

            if (reverseStr.Contains(s))
            {
                return str.Length - 1;
            }

            return 1;
        }
    }
}
