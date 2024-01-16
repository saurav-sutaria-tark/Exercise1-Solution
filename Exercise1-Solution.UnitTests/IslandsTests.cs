using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise1_Solution.Solutions;

namespace Exercise1_Solution.UnitTests
{
    [TestClass]
    public class IslandsTests
    {
        [TestMethod]
        public void BeachLength_TestCase1_ReturnsLength()
        {
            Islands islands = new Islands();
            var result = islands.BeachLength(new string[]{ ".#...#.."});
            Assert.IsTrue(result == 4);
        }[TestMethod]
        public void BeachLength_TestCase2_ReturnsLength()
        {
            Islands islands = new Islands();
            var result = islands.BeachLength(new string[]{"..#.##",".##.#.","#.#..."});
            Assert.IsTrue(result == 19);
        }[TestMethod]
        public void BeachLength_TestCase3_ReturnsLength()
        {
            Islands islands = new Islands();
            var result = islands.BeachLength(new string[]{"#...#.....","##..#...#."});
            Assert.IsTrue(result == 15);
        }[TestMethod]
        public void BeachLength_TestCase4_ReturnsLength()
        {
            Islands islands = new Islands();
            var result = islands.BeachLength(new string[]{"....#.",".#....","..#..#","####.."});
            Assert.IsTrue(result == 24);
        }
    }
}
