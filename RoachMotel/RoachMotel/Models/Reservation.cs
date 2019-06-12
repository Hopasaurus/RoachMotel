using System;
using System.Collections.Generic;

namespace RoachMotel.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public Guest Guest { get; set; }
        public List<RoomFeature> RoomFeatures { get; set; }
        public DateTimeOffset CheckIn { get; set; }
        public DateTimeOffset CheckOut { get; set; }
    }
}
