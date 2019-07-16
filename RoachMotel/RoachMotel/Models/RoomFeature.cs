namespace RoachMotel.Models
{
    public class RoomFeature
    {
        public string Name { get; set; }
        public decimal Cost { get; set; }

        public RoomFeature(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }

        public RoomFeature(string name)
        {
            Name = name;
        }
    }
}
