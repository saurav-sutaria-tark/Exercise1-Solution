using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise1_Solution.Solutions;

namespace Exercise1_Solution.UnitTests
{
    [TestClass]
    public class LargestSubsequenceTests
    {
        [TestMethod]
        public void GetLargest_TestCase1_ReturnsTrue()
        {
            LargestSubsequence largestSubsequence = new LargestSubsequence();
            var result = largestSubsequence.GetLargest("test");
            Assert.IsTrue(result == "tt");
        } [TestMethod]
        public void GetLargest_TestCase2_ReturnsTrue()
        {
            LargestSubsequence largestSubsequence = new LargestSubsequence();
            var result = largestSubsequence.GetLargest("a");
            Assert.IsTrue(result == "a");
        } [TestMethod]
        public void GetLargest_TestCase3_ReturnsTrue()
        {
            LargestSubsequence largestSubsequence = new LargestSubsequence();
            var result = largestSubsequence.GetLargest("example");
            Assert.IsTrue(result == "xple");
        } [TestMethod]
        public void GetLargest_TestCase4_ReturnsTrue()
        {
            LargestSubsequence largestSubsequence = new LargestSubsequence();
            var result = largestSubsequence.GetLargest("aquickbrownfoxjumpsoverthelazydog");
            Assert.IsTrue(result == "zyog");
        }
    }
}
