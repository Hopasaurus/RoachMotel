using System.Collections.Generic;

namespace RoachMotel.Models
{
    public class Motel
    {
        public int Id { get; set; }
        public string Owner { get; set; }
        public string Address { get; set; }
        public List<Room> Rooms { get; set; }
        public List<Reservation> Reservations { get; set; }

        public void AddReservation(Reservation reservation)
        {
            
        }

        public void CancelReservation(Reservation reservation)
        {
            
        }

        public void CheckIn(Reservation reservation)
        {
            
        }

        public void CheckIn(Room room, Guest guest)
        {
            
        }

        public void CheckOut(Room room)
        {
            
        }
    }
}
