namespace RoachMotel.Models
{
    public class RoomFeature
    {
        public FeatureNames Name { get; set; }
        public decimal Cost { get; set; }

        public RoomFeature(FeatureNames name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }

        public RoomFeature(FeatureNames name)
        {
            Name = name;

            // TODO: I put this in, but should there be a test to force it, pin it and justify it?
            // Cost = 0;
        }
    }
}
