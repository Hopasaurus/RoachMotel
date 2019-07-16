using System.Collections.Generic;
using RoachMotel.Models;

namespace RoachMotelTest
{
    public static class TestHelper
    {
        public static Motel BuildMotel()
        {
            var motel = new Motel
            {
                Rooms = new List<Room>
                {
                    new Room
                    {
                        Features = new List<RoomFeature>
                        {
                            new RoomFeature(FeatureNames.ONE_BED),
                        },
                        RoomName = "1BedA",
                        Status = Statuses.EMPTY,
                    },
                    new Room
                    {
                        Features = new List<RoomFeature>
                        {
                            new RoomFeature(FeatureNames.ONE_BED),
                        },
                        RoomName = "1BedB",
                        Status = Statuses.NEEDS_CLEANING,
                    },
                    new Room
                    {
                        Features = new List<RoomFeature>
                        {
                            new RoomFeature(FeatureNames.ONE_BED),
                            new RoomFeature(FeatureNames.TWO_BEDS),
                        },
                        RoomName = "2BedA",
                        Status = Statuses.EMPTY,
                    },
                    new Room
                    {
                        Features = new List<RoomFeature>
                        {
                            new RoomFeature(FeatureNames.ONE_BED),
                            new RoomFeature(FeatureNames.TWO_BEDS),
                            new RoomFeature(FeatureNames.THREE_BEDS),
                            new RoomFeature(FeatureNames.ACCESSIBLE),
                        },
                        RoomName = "3BedAndAccessible",
                        Status = Statuses.EMPTY,
                    },
                }
            };
            return motel;
        }
    }
}
