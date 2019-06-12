using System;

namespace RoachMotel.Models
{
    public class CheckOut
    {
        public Guest Guest { get; set; }
        public Room Room { get; set; }
        public DateTimeOffset Time { get; set; }
    }
}