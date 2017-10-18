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

        [TestMethod]
        public void Input_caab_string()
        {
            var kata = new Kata();
            var result = kata.GetLongestPalindrome("caab");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Input_abc0cba1_string()
        {
            var kata = new Kata();
            var result = kata.GetLongestPalindrome("abc0cba1");
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void Input_12_21glg_string()
        {
            var kata = new Kata();
            var result = kata.GetLongestPalindrome("12 21glg");
            Assert.AreEqual(5, result);
        }


        [TestMethod]
        public void Input_3_whitespace_string()
        {
            var kata = new Kata();
            var result = kata.GetLongestPalindrome("   ");
            Assert.AreEqual(3, result);
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

            var result = new List<int>();
            for (var skip = 0; skip < str.Length; skip++)
            {
                for (var take = 1; take <= str.Length; take++)
                {
                    var s = string.Concat(str.Skip(skip).Take(take));

                    if (reverseStr.Contains(s))
                    {
                        result.Add(s.Length);
                    }
                }
            }

            return result.Any() ? result.Max() : 1;
        }
    }
}
