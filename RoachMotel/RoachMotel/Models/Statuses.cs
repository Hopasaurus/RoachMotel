namespace RoachMotel.Models
{
    public static class Statuses
    {
        public const string EMPTY = "EMPTY";
        public const string OCCUPIED = "OCCUPIED";
        public const string NEEDS_CLEANING = "NEEDS_CLEANING";          // replace sheets, replace towels and really clean thing.
        public const string NEEDS_HOUSEKEEPING = "NEEDS_HOUSEKEEPING";  // make bed, replace towels, don't steal things. 
    }
}
