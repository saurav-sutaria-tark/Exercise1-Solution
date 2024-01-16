using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise1_Solution.Solutions;

namespace Exercise1_Solution.UnitTests
{
    [TestClass]
    public class HuffmanDecodingTests
    {
        [TestMethod]
        public void Decode_TestCase0_ReturnsTrue()
        {
            HuffmanDecoding huffmanDecoding = new HuffmanDecoding();
            var result = huffmanDecoding.Decode("101101", new string[] { "00", "10", "01", "11" });
            Assert.AreEqual(result, "BDC");
        }
        [TestMethod]
        public void Decode_TestCase1_ReturnsTrue()
        {
            HuffmanDecoding huffmanDecoding = new HuffmanDecoding();
            var result = huffmanDecoding.Decode("10111010", new string[] { "0", "111", "10" });
            Assert.AreEqual(result, "CBAC");
        }
         [TestMethod]
        public void Decode_TestCase2_ReturnsTrue()
        {
            HuffmanDecoding huffmanDecoding = new HuffmanDecoding();
            var result = huffmanDecoding.Decode("0001001100100111001", new string[] { "1", "0" });
            Assert.AreEqual(result, "BBBABBAABBABBAAABBA");
        }
         [TestMethod]
        public void Decode_TestCase3_ReturnsTrue()
        {
            HuffmanDecoding huffmanDecoding = new HuffmanDecoding();
            var result = huffmanDecoding.Decode("111011011000100110", new string[] { "010", "00", "0110", "0111", "11", "100", "101" });
            Assert.AreEqual(result, "EGGFAC");
        }
         [TestMethod]
        public void Decode_TestCase4_ReturnsTrue()
        {
            HuffmanDecoding huffmanDecoding = new HuffmanDecoding();
            var result = huffmanDecoding.Decode("001101100101100110111101011001011001010", new string[] { "110", "011", "10", "0011", "00011", "111", "00010", "0010", "010", "0000" });
            Assert.AreEqual(result, "DBHABBACAIAIC");
        }
       

    }
}
