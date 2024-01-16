using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise1_Solution.Solutions;

namespace Exercise1_Solution.UnitTests
{
    [TestClass]
    public class LexmaxReplaceTests
    {
        [TestMethod]
        public void Get_TestCase1_ReturnsTrue()
        {
            LexmaxReplace lexmaxReplace = new LexmaxReplace();
            var result = lexmaxReplace.Get("abb", "c").ToString();
            Assert.IsTrue(result == "cbb");
        } [TestMethod]
        public void Get_TestCase2_ReturnsTrue()
        {
            LexmaxReplace lexmaxReplace = new LexmaxReplace();
            var result = lexmaxReplace.Get("z", "f").ToString();
            Assert.IsTrue(result == "z");
        } [TestMethod]
        public void Get_TestCase3_ReturnsTrue()
        {
            LexmaxReplace lexmaxReplace = new LexmaxReplace();
            var result = lexmaxReplace.Get("fedcba", "ee").ToString();
            Assert.IsTrue(result == "feeeba");
        } [TestMethod]
        public void Get_TestCase4_ReturnsTrue()
        {
            LexmaxReplace lexmaxReplace = new LexmaxReplace();
            var result = lexmaxReplace.Get("top","coder").ToString();
            Assert.IsTrue(result == "trp");
        } [TestMethod]
        public void Get_TestCase5_ReturnsTrue()
        {
            LexmaxReplace lexmaxReplace = new LexmaxReplace();
            var result = lexmaxReplace.Get("xldyzmsrrwzwaofkcxwehgvtrsximxgdqrhjthkgfucrjdvwlr", "xfpidmmilhdfzypbguentqcojivertdhshstkcysydgcwuwhlk").ToString();
            Assert.IsTrue(result == "zyyyzyxwwwzwvuuttxwtssvtssxrqxppqrontmmllukrkjvwlr");
        }
    }
}
