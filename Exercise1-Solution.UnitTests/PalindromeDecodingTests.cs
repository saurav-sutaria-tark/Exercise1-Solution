using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise1_Solution.Solutions;

namespace Exercise1_Solution.UnitTests
{
    [TestClass]
    public class PalindromeDecodingTests
    {
        [TestMethod]
        public void Decode_TestCase1_ReturnsTrue()
        {
            PalindromeDecoding palindromeDecoding = new PalindromeDecoding();
            var result = palindromeDecoding.Decode("ab", new int[] { 0 }, new int[] { 2 });
            Assert.IsTrue(result == "abba");
        } [TestMethod]
        public void Decode_TestCase2_ReturnsTrue()
        {
            PalindromeDecoding palindromeDecoding = new PalindromeDecoding();
            var result = palindromeDecoding.Decode("Misip", new int[] { 2, 3, 1, 7 }, new int[] { 1, 1, 2, 2 });
            Assert.IsTrue(result == "Mississippi");
        } [TestMethod]
        public void Decode_TestCase3_ReturnsTrue()
        {
            PalindromeDecoding palindromeDecoding = new PalindromeDecoding();
            var result = palindromeDecoding.Decode("XY", new int[] { 0, 0, 0, 0 }, new int[] { 2, 4, 8, 16 });
            Assert.IsTrue(result == "XYYXXYYXXYYXXYYXXYYXXYYXXYYXXYYX");
        } [TestMethod]
        public void Decode_TestCase4_ReturnsTrue()
        {
            PalindromeDecoding palindromeDecoding = new PalindromeDecoding();
            var result = palindromeDecoding.Decode("TC206", new int[] { 1, 2, 5 }, new int[] { 1, 1, 1 });
            Assert.IsTrue(result == "TCCC2006");
        } [TestMethod]
        public void Decode_TestCase5_ReturnsTrue()
        {
            PalindromeDecoding palindromeDecoding = new PalindromeDecoding();
            var result = palindromeDecoding.Decode("nodecoding", new int[] { }, new int[] { });
            Assert.IsTrue(result == "nodecoding");
        }
    }
}
