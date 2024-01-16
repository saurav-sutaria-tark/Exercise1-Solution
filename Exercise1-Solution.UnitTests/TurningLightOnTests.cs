using Exercise1_Solution.Solutions;
namespace Exercise1_Solution.UnitTests
{
    [TestClass]
    public class TurningLightOnTests
    {
        [TestMethod]
        public void MinFlips_TestCase1_ReturnsTrue()
        {
            //arrange
            TurningLightOn turningLightOn = new TurningLightOn();

            //act
            var result = turningLightOn.MinFlips(new string[] { "0001111", "0001111", "1111111" });


            //assert
            Assert.IsTrue(result == 1);
            
        }
        [TestMethod]
        public void MinFlips_TestCase2_ReturnsTrue()
        {
            //arrange
            TurningLightOn turningLightOn = new TurningLightOn();

            //act
            var result = turningLightOn.MinFlips(new string[] { "1111111", "1111111", "1111111" });


            //assert
            Assert.IsTrue(result == 0);

        } [TestMethod]
        public void MinFlips_TestCase3_ReturnsTrue()
        {
            //arrange
            TurningLightOn turningLightOn = new TurningLightOn();

            //act
            var result = turningLightOn.MinFlips(new string[] { "01001" });


            //assert
            Assert.IsTrue(result == 3);

        } [TestMethod]
        public void MinFlips_TestCase4_ReturnsTrue()
        {
            //arrange
            TurningLightOn turningLightOn = new TurningLightOn();

            //act
            var result = turningLightOn.MinFlips(new string[] { "0101", "1010", "0101", "1010" });


            //assert
            Assert.IsTrue(result == 7);

        }

    }
}