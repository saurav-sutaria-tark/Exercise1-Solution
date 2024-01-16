using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise1_Solution.Solutions;

namespace Exercise1_Solution.UnitTests
{
    [TestClass]
    public class SortingSubsetsTests
    {
        [TestMethod]
        public void GetMinimalSize_TestCase1_ReturnsTrue()
        {
            SortingSubsets sortingSubsets = new SortingSubsets();
            var result = sortingSubsets.GetMinimalSize(new int[] { 3, 2, 1 });
            Assert.IsTrue(result == 2);
        }
        [TestMethod]
        public void GetMinimalSize_TestCase2_ReturnsTrue()
        {
            SortingSubsets sortingSubsets = new SortingSubsets();
            var result = sortingSubsets.GetMinimalSize(new int[] { 1, 2, 3, 4 });
            Assert.IsTrue(result == 0);
        }
        [TestMethod]
        public void GetMinimalSize_TestCase3_ReturnsTrue()
        {
            SortingSubsets sortingSubsets = new SortingSubsets();
            var result = sortingSubsets.GetMinimalSize(new int[] { 4, 4, 4, 3, 3, 3 });
            Assert.IsTrue(result == 6);
        }
        [TestMethod]
        public void GetMinimalSize_TestCase4_ReturnsTrue()
        {
            SortingSubsets sortingSubsets = new SortingSubsets();
            var result = sortingSubsets.GetMinimalSize(new int[] { 11, 11, 49, 7, 11, 11, 7, 7, 11, 49, 11 });
            Assert.IsTrue(result == 7);
        }
    }
}
