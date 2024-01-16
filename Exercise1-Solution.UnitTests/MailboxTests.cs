using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise1_Solution.Solutions;

namespace Exercise1_Solution.UnitTests
{
    [TestClass]
    public class MailboxTests
    {
        [TestMethod]
        public void Impossible_TestCase1_ReturnsTrue()
        {
            Mailbox mailbox = new Mailbox();
            var result = mailbox.Impossible("AAAAAAABBCCCCCDDDEEE123456789", new string[] { "123C", "123A", "123 ADA" });
            Assert.IsTrue(result == 0);
        } [TestMethod]
        public void Impossible_TestCase2_ReturnsTrue()
        {
            Mailbox mailbox = new Mailbox();
            var result = mailbox.Impossible("ABCDEFGHIJKLMNOPRSTUVWXYZ1234567890", new string[] { "2 FIRST ST", " 31 QUINCE ST", "606 BAKER" });
            Assert.IsTrue(result == 3);
        } [TestMethod]
        public void Impossible_TestCase3_ReturnsTrue()
        {
            Mailbox mailbox = new Mailbox();
            var result = mailbox.Impossible("ABCDAAST", new string[] { "111 A ST", "A BAD ST", "B BAD ST" });
            Assert.IsTrue(result == 2);
        }
    }
}
