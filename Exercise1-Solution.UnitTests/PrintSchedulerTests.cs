using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise1_Solution.Solutions;

namespace Exercise1_Solution.UnitTests
{
    [TestClass]
    public class PrintSchedulerTests
    {
        [TestMethod]
        public void GetOutput_TestCase1_ReturnsTrue()
        {
            PrintScheduler printScheduler = new PrintScheduler();   
            var result = printScheduler.GetOutput(new string[] { "AB", "CD" }, new string[] { "0 1", "1 1", "0 1", "1 2" });
            Assert.IsTrue(result == "ACBDC");
        } [TestMethod]
        public void GetOutput_TestCase2_ReturnsTrue()
        {
            PrintScheduler printScheduler = new PrintScheduler();   
            var result = printScheduler.GetOutput(new string[] { "ABCDE" }, new string[] { "0 20", "0 21" });
            Assert.IsTrue(result == "ABCDEABCDEABCDEABCDEABCDEABCDEABCDEABCDEA");
        } [TestMethod]
        public void GetOutput_TestCase3_ReturnsTrue()
        {
            PrintScheduler printScheduler = new PrintScheduler();   
            var result = printScheduler.GetOutput(new string[] { "A", "B" }, new string[] { "1 10", "0 1", "1 10", "0 2" });
            Assert.IsTrue(result == "BBBBBBBBBBABBBBBBBBBBAA");
        } [TestMethod]
        public void GetOutput_TestCase4_ReturnsTrue()
        {
            PrintScheduler printScheduler = new PrintScheduler();   
            var result = printScheduler.GetOutput(new string[] { "A" }, new string[] { "0 1" });
            Assert.IsTrue(result ==  "A");
        }
    }
}
