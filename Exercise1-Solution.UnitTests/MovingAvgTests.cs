using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise1_Solution.Solutions;

namespace Exercise1_Solution.UnitTests
{
    [TestClass]
    public class MovingAvgTests
    {
        [TestMethod]
        public void Difference_TestCase1_ReturnsTrue()
        {
            MovingAvg movingAvg = new MovingAvg();
            var result = movingAvg.Difference(2, new double[] { 3, 8, 9, 15 });
            Assert.IsTrue(result == 6.5);
        }[TestMethod]
        public void Difference_TestCase2_ReturnsTrue()
        {
            MovingAvg movingAvg = new MovingAvg();
            var result = movingAvg.Difference(3, new double[] { 17, 6.2, 19, 3.4 });
            Assert.IsTrue(result == 4.533333333333335);
        }[TestMethod]
        public void Difference_TestCase3_ReturnsTrue()
        {
            MovingAvg movingAvg = new MovingAvg();
            var result = movingAvg.Difference(3, new double[] { 6, 2.5, 3.5 });
            Assert.IsTrue(result == 0.0);
        }
    }
}
