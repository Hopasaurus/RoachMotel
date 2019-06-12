using System;

namespace RoachMotel.Models
{
    public class CheckIn
    {
        public Guest Guest { get; set; }
        public Reservation Reservation { get; set; }
        public Room Room { get; set; }
        public DateTimeOffset Time { get; set; }
    }
}
