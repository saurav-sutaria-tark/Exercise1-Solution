using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise1_Solution.Solutions;

namespace Exercise1_Solution.UnitTests
{
    [TestClass]
    public class MaximumBalancesTests
    {
        [TestMethod]
        public void Solve_TestCase1_ReturnsTrue()
        {
            MaximumBalances maximumBalances = new MaximumBalances();
            var result = maximumBalances.Solve("((((");
            Assert.IsTrue(result == 0);
        }[TestMethod]
        public void Solve_TestCase2_ReturnsTrue()
        {
            MaximumBalances maximumBalances = new MaximumBalances();
            var result = maximumBalances.Solve("(())");
            Assert.IsTrue(result == 3);
        }public void Solve_TestCase3_ReturnsTrue()
        {
            MaximumBalances maximumBalances = new MaximumBalances();
            var result = maximumBalances.Solve(")))())");
            Assert.IsTrue(result == 1);
        }public void Solve_TestCase4_ReturnsTrue()
        {
            MaximumBalances maximumBalances = new MaximumBalances();
            var result = maximumBalances.Solve("))()()))(()");
            Assert.IsTrue(result == 10);
        }
    }
}
