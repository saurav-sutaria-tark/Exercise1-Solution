using Exercise1_Solution.Solutions;
namespace Exercise1_Solution.UnitTests
{
    [TestClass]
    public class DukeOnChessBoardTest
    {
        [TestMethod]
        public void DukePath_TestCase1_ReturnsTrue()
        {
            DukeOnChessBoard dukeOnChessBoard = new DukeOnChessBoard();
            var result = dukeOnChessBoard.DukePath(3, "b2");
            Assert.IsTrue(result == "b2-c2-c3-b3-a3-a2-a1-b1-c1");
        }
        [TestMethod]
        public void DukePath_TestCase2_ReturnsTrue()
        {
            DukeOnChessBoard dukeOnChessBoard = new DukeOnChessBoard();
            var result = dukeOnChessBoard.DukePath(4, "d4");
            Assert.IsTrue(result == "d4-d3-d2-d1-c1-c2-c3...b3-b2-b1-a1-a2-a3-a4");
        }[TestMethod]
        public void DukePath_TestCase3_ReturnsTrue()
        {
            DukeOnChessBoard dukeOnChessBoard = new DukeOnChessBoard();
            var result = dukeOnChessBoard.DukePath(3, "a2");
            Assert.IsTrue(result == "a2-b2-c2-c3-b3-a3");
        }[TestMethod]
        public void DukePath_TestCase4_ReturnsTrue()
        {
            DukeOnChessBoard dukeOnChessBoard = new DukeOnChessBoard();
            var result = dukeOnChessBoard.DukePath(4, "d3");
            Assert.IsTrue(result == "d3-d4-c4-c3-c2-d2-d1...b2-b3-b4-a4-a3-a2-a1");
        }[TestMethod]
        public void DukePath_TestCase5_ReturnsTrue()
        {
            DukeOnChessBoard dukeOnChessBoard = new DukeOnChessBoard();
            var result = dukeOnChessBoard.DukePath(8, "a8");
            Assert.IsTrue(result == "a8-b8-c8-d8-e8-f8-g8...a1-a2-a3-a4-a5-a6-a7");
        }

    }
}
