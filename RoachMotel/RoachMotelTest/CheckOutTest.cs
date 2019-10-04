using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RoachMotelTest
{
    [TestClass]
    public class CheckOutTest
    {
        [TestMethod]
        public void Test_CheckOutShouldSetRoomToNeedsCleaning()
        {
            var motel = TestHelper.BuildMotel();

            var room = motel.Rooms[0];
            room.Status = "FOO";  // status should probably be turned into an enum

            motel.CheckOut(room);

            Assert.AreEqual("NEEDS_CLEANING", motel.Rooms[0].Status);
        }
    }
}
