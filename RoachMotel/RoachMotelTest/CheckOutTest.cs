using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoachMotel.Models;

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
            room.Status = Statuses.Empty;

            motel.CheckOut(room);

            Assert.AreEqual(Statuses.NeedsCleaning, motel.Rooms[0].Status);
        }
    }
}
