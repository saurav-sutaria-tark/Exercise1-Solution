using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise1_Solution.Solutions;

namespace Exercise1_Solution.UnitTests
{
    [TestClass]
    public class MysticAndCandiesEasyTests
    {
        [TestMethod]
        public void MinBoxes_TestCase1_ReturnsTrue()
        {
            MysticAndCandiesEasy mysticAndCandiesEasy = new MysticAndCandiesEasy();
            var result = mysticAndCandiesEasy.MinBoxes(10, 10, new int[] { 20 });
            Assert.IsTrue(result == 1);
        }[TestMethod]
        public void MinBoxes_TestCase2_ReturnsTrue()
        {
            MysticAndCandiesEasy mysticAndCandiesEasy = new MysticAndCandiesEasy();
            var result = mysticAndCandiesEasy.MinBoxes(10, 7, new int[] { 3, 3, 3, 3, 3 });
            Assert.IsTrue(result == 4);
        }[TestMethod]
        public void MinBoxes_TestCase3_ReturnsTrue()
        {
            MysticAndCandiesEasy mysticAndCandiesEasy = new MysticAndCandiesEasy();
            var result = mysticAndCandiesEasy.MinBoxes(100, 63, new int[] { 12, 34, 23, 45, 34 });
            Assert.IsTrue(result == 3);
        }[TestMethod]
        public void MinBoxes_TestCase4_ReturnsTrue()
        {
            MysticAndCandiesEasy mysticAndCandiesEasy = new MysticAndCandiesEasy();
            var result = mysticAndCandiesEasy.MinBoxes(19, 12, new int[] { 12, 9, 15, 1, 6, 4, 9, 10, 10, 10, 14, 14, 1, 1, 12, 10, 9, 2, 3, 6, 1, 7, 3, 4, 10, 3, 14 });
            Assert.IsTrue(result == 22);
        }[TestMethod]
        public void MinBoxes_TestCase5_ReturnsTrue()
        {
            MysticAndCandiesEasy mysticAndCandiesEasy = new MysticAndCandiesEasy();
            var result = mysticAndCandiesEasy.MinBoxes(326, 109, new int[] { 9, 13, 6, 6, 6, 16, 16, 16, 10, 16, 4, 3, 10, 8, 11, 17, 12, 5, 7, 8, 7, 4, 15, 7, 14, 2, 2, 1, 17, 1, 7, 7, 12, 17, 2, 9, 7, 1, 8, 16, 7, 4, 16, 2, 13, 3, 13, 1, 17, 6 });
            Assert.IsTrue(result == 15);
        }
    }
}
