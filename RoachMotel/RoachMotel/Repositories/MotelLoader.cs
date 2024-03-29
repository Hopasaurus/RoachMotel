﻿using System.Collections.Generic;
using RoachMotel.Models;

namespace RoachMotel.Repositories
{
    public static class MotelLoader
    {
        // hard coded motel, this is "Fake it 'til you make it" development
        // this is enough to get started with for now.
        public static Motel LoadMotel()
        {
            return new Motel
            {
                Owner = "Happy Motel Owner",
                Address = "123 Main st, anywhere usa",
                Id = 1,
                Rooms = new List<Room>
                {
                    // first floor, accessible, pets allowed.
                    BuildRoom("100", 1, true, true),
                    BuildRoom("101", 1, true, true),
                    BuildRoom("102", 2, true, true),
                    BuildRoom("103", 2, true, true),
                    BuildRoom("104", 3, true, true),
                    BuildRoom("105", 3, true, true),
                    
                    // second floor, not accessible, no pets
                    BuildRoom("200", 1, true, false),
                    BuildRoom("201", 1, true, false),
                    BuildRoom("202", 2, true, false),
                    BuildRoom("203", 2, true, false),
                    BuildRoom("204", 3, true, false),
                    BuildRoom("205", 3, true, false),
                },
            };
        }

        private static Room BuildRoom(string name, int bedCount, bool accessible, bool pets)
        {
            var features = new List<RoomFeature>
            {
                new RoomFeature(FeatureNames.OneBed, 50)
            };


            if (bedCount > 1)
            {
                features.Add(new RoomFeature(FeatureNames.TwoBeds, 25));
            }

            if (bedCount > 2)
            {
                features.Add(new RoomFeature(FeatureNames.ThreeBeds, 15));
            }

            if (accessible)
            {
                features.Add(new RoomFeature(FeatureNames.Accessible, 0));
            }

            if (pets)
            {
                features.Add(new RoomFeature(FeatureNames.OneBed, 20));
                features.Add(new RoomFeature(FeatureNames.TwoPets, 20));
            }

            return new Room
            {
                RoomName = name,
                Features = features
            };
        }
    }
}
