using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoachMotel;

namespace RoachMotelTest
{
    [TestClass]
    public class SanityTest
    {
        [TestMethod]
        public void Test_CheckInAllowedShouldReturnTrue()
        {
            var sanity = new Sanity();

            Assert.IsTrue(sanity.CheckInAllowed());
        }

        [TestMethod]
        public void Test_CheckOutAllowedShouldReturnFalse()
        {
            var sanity = new Sanity();

            Assert.IsFalse(sanity.CheckOutAllowed());
        }
    }
}
