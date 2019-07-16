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
                new RoomFeature(FeatureNames.ONE_BED)
            };

            var room = motel.CheckIn(requestedFeatures);

            Assert.AreEqual("1BedA", room.RoomName);
        }

        [TestMethod]
        public void Test_CheckInShouldSetTheRoomToOccupied()
        {
            var motel = TestHelper.BuildMotel();

            Assert.AreEqual("EMPTY", motel.Rooms[0].Status);

            var requestedFeatures = new List<RoomFeature>
            {
                new RoomFeature(FeatureNames.ONE_BED)
            };

            
            motel.CheckIn(requestedFeatures);

            Assert.AreEqual("OCCUPIED", motel.Rooms[0].Status);
        }

        [TestMethod]
        public void Test_CheckInShouldNotPresentRoomsNeedingCleaning()
        {
            var motel = TestHelper.BuildMotel();
            motel.Rooms[0].Status = Statuses.NEEDS_CLEANING;

            var requestedFeatures = new List<RoomFeature>
            {
                new RoomFeature(FeatureNames.ONE_BED)
            };

            var room = motel.CheckIn(requestedFeatures);

            Assert.AreEqual("2BedA", room.RoomName);
        }

        [TestMethod]
        public void Test_CheckInShouldHonorAccessibilityPreference()
        {
            var motel = TestHelper.BuildMotel();
            motel.Rooms[0].Status = Statuses.NEEDS_CLEANING;

            var requestedFeatures = new List<RoomFeature>
            {
                new RoomFeature(FeatureNames.ONE_BED),
                new RoomFeature(FeatureNames.ACCESSIBLE)
            };

            var room = motel.CheckIn(requestedFeatures);

            Assert.AreEqual("3BedAndAccessible", room.RoomName);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Test_CheckInThrowsWhenNoRoomsMatchSpec()
        {
            var motel = TestHelper.BuildMotel();
            motel.Rooms[0].Status = Statuses.NEEDS_CLEANING;

            var requestedFeatures = new List<RoomFeature>
            {
                new RoomFeature(FeatureNames.ONE_BED),
                new RoomFeature(FeatureNames.TWO_PETS)
            };

            motel.CheckIn(requestedFeatures);
        }
    }
}
