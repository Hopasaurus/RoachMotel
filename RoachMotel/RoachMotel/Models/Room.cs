﻿using System.Collections.Generic;

namespace RoachMotel.Models
{
    public class Room
    {
        public string RoomName { get; set; }
        public List<RoomFeature> Features { get; set; }
        public Statuses Status { get; set; }

        public bool HasFeatures(List<RoomFeature> features)
        {
            // This is pretty intense, there is a physical limitation on the size of 
            // a motel or this could have bad run time implications 
            return features.TrueForAll(
                requestedFeature => Features.Exists(roomFeature => roomFeature.Name == requestedFeature.Name));
        }

        public bool IsEmpty()
        {
            return Status == Statuses.Empty;
        }

        public void AddFeature(FeatureNames featureName, decimal cost = decimal.Zero)
        {
            Features.Add(new RoomFeature(featureName, cost));
        }

        public void RemoveFeature(FeatureNames featureName)
        {
            Features.RemoveAll(feature => feature.Name == featureName);
        }
    }
}