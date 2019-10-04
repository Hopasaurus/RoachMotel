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
                            new RoomFeature(FeatureNames.OneBed),
                        },
                        RoomName = "1BedA",
                        Status = Statuses.Empty,
                    },
                    new Room
                    {
                        Features = new List<RoomFeature>
                        {
                            new RoomFeature(FeatureNames.OneBed),
                        },
                        RoomName = "1BedB",
                        Status = Statuses.NeedsCleaning,
                    },
                    new Room
                    {
                        Features = new List<RoomFeature>
                        {
                            new RoomFeature(FeatureNames.OneBed),
                            new RoomFeature(FeatureNames.TwoBeds),
                        },
                        RoomName = "2BedA",
                        Status = Statuses.Empty,
                    },
                    new Room
                    {
                        Features = new List<RoomFeature>
                        {
                            new RoomFeature(FeatureNames.OneBed),
                            new RoomFeature(FeatureNames.TwoBeds),
                            new RoomFeature(FeatureNames.ThreeBeds),
                            new RoomFeature(FeatureNames.Accessible),
                        },
                        RoomName = "3BedAndAccessible",
                        Status = Statuses.Empty,
                    },
                }
            };
            return motel;
        }
    }
}
