using System.Collections.Generic;
using System.Linq;

namespace RoachMotel.Models
{
    public class Motel
    {
        public int Id { get; set; }
        public string Owner { get; set; }
        public string Address { get; set; }
        public List<Room> Rooms { get; set; }

        public Room FindAvailableRoom(List<RoomFeature> features)
        {
            // this should throw if there are no rooms available.
            // people would probably whine about the generic exception forcing us to make a
            // specific exception in the next iteration.
            // either way it should be caught somewhere that can help the user deal with it.
            return FindAvailableRooms(features).First();
        }

        public IEnumerable<Room> FindAvailableRooms(List<RoomFeature> features)
        {
            // get a list of empty rooms that satisfy the features given.
            // The list could be used to allow the front desk person to add some intelligence.
            // For now FindAvailableRoom will just take the first room from the list.
            return Rooms.Where(r => r.IsEmpty() && r.HasFeatures(features));
        }

        public Room CheckIn(List<RoomFeature> requestedFeatures)
        {
            var room = FindAvailableRoom(requestedFeatures);
            room.Status = Statuses.OCCUPIED;
            return room;
        }

        public void CheckOut(Room room)
        {
            room.Status = Statuses.NEEDS_CLEANING;
        }

        public void Clean()
        {
            // Simulate cleaning all the dirty rooms.
            // In reality house keeping would mark rooms cleaned once they are really cleaned (I hope)

            foreach (var room in Rooms.Where(r => r.Status == Statuses.NEEDS_CLEANING))
            {
                room.Status = Statuses.EMPTY;
            }
        }
    }
}
