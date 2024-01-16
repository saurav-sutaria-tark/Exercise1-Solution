using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise1_Solution.Solutions;

namespace Exercise1_Solution.UnitTests
{
    [TestClass]
    public class WordCompositionGameTests
    {
        [TestMethod]
        public void Score_TestCase1_ReturnsTrue()
        {
            WordCompositionGame game = new WordCompositionGame();
            var result = game.Score(new string[] { "cat", "dog", "pig", "mouse" }, new string[] { "cat", "pig" }, new string[] { "dog", "cat" });
            Assert.IsTrue(result == "8/3/3");
        }[TestMethod]
        public void Score_TestCase2_ReturnsTrue()
        {
            WordCompositionGame game = new WordCompositionGame();
            var result = game.Score(new string[] { "mouse" }, new string[] { "cat", "pig" }, new string[] { "dog", "cat" });
            Assert.IsTrue(result == "3/5/5");
        }[TestMethod]
        public void Score_TestCase3_ReturnsTrue()
        {
            WordCompositionGame game = new WordCompositionGame();
            var result = game.Score(new string[] { "dog", "mouse" }, new string[] { "dog", "pig" }, new string[] { "dog", "cat" });
            Assert.IsTrue(result == "4/4/4");
        }[TestMethod]
        public void Score_TestCase4_ReturnsTrue()
        {
            WordCompositionGame game = new WordCompositionGame();
            var result = game.Score(new string[] { "bcdbb", "aaccd", "dacbc", "bcbda", "cdedc", "bbaaa", "aecae" }, new string[] { "bcdbb", "ddacb", "aaccd", "adcab", "edbee", "aecae", "bcbda" }, new string[] { "dcaab", "aadbe", "bbaaa", "ebeec", "eaecb", "bcbba", "aecae", "adcab", "bcbda" });
            Assert.IsTrue(result == "14/14/21");
        }
    }
}
