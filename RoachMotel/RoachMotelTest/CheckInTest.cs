using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoachMotel.Models;

namespace RoachMotelTest
{
    [TestClass]
    public class CheckInTest
    {
        [TestMethod]
        public void Test_CheckInShouldPresentTheFirstAvailableRoomMatchingRequest()
        {
            var motel = TestHelper.BuildMotel();

            var requestedFeatures = new List<RoomFeature>
            {
                new RoomFeature(FeatureNames.OneBed)
            };

            var room = motel.CheckIn(requestedFeatures);

            Assert.AreEqual("1BedA", room.RoomName);
        }

        [TestMethod]
        public void Test_CheckInShouldSetTheRoomToOccupied()
        {
            var motel = TestHelper.BuildMotel();

            Assert.AreEqual(Statuses.Empty, motel.Rooms[0].Status);

            var requestedFeatures = new List<RoomFeature>
            {
                new RoomFeature(FeatureNames.OneBed)
            };

            
            motel.CheckIn(requestedFeatures);

            Assert.AreEqual(Statuses.Occupied, motel.Rooms[0].Status);
        }

        [TestMethod]
        public void Test_CheckInShouldNotPresentRoomsNeedingCleaning()
        {
            var motel = TestHelper.BuildMotel();
            motel.Rooms[0].Status = Statuses.NeedsCleaning;

            var requestedFeatures = new List<RoomFeature>
            {
                new RoomFeature(FeatureNames.OneBed)
            };

            var room = motel.CheckIn(requestedFeatures);

            Assert.AreEqual("2BedA", room.RoomName);
        }

        [TestMethod]
        public void Test_CheckInShouldHonorAccessibilityPreference()
        {
            var motel = TestHelper.BuildMotel();
            motel.Rooms[0].Status = Statuses.NeedsCleaning;

            var requestedFeatures = new List<RoomFeature>
            {
                new RoomFeature(FeatureNames.OneBed),
                new RoomFeature(FeatureNames.Accessible)
            };

            var room = motel.CheckIn(requestedFeatures);

            Assert.AreEqual("3BedAndAccessible", room.RoomName);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Test_CheckInThrowsWhenNoRoomsMatchSpec()
        {
            var motel = TestHelper.BuildMotel();
            motel.Rooms[0].Status = Statuses.NeedsCleaning;

            var requestedFeatures = new List<RoomFeature>
            {
                new RoomFeature(FeatureNames.OneBed),
                new RoomFeature(FeatureNames.TwoPets)
            };

            motel.CheckIn(requestedFeatures);
        }
    }
}
