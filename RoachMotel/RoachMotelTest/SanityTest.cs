using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoachMotel;

namespace RoachMotelTest
{
    [TestClass]
    public class SanityTest
    {
        // ok Hoppe, what on earth is this... I think you are putting YOUR sanity to the test.
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
