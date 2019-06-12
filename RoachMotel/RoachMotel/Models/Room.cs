using System.Collections.Generic;

namespace RoachMotel.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public List<RoomFeature> RoomFeatures { get; set; }
    }
}