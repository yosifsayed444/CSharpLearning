using System;
using System.Collections.Generic;
using System.Text;

namespace ReservationHotelSystem.Classes
{
    internal class StandardReservation : Reservation
    {
        private IRoom StandardRoom;
        public override IRoom room { get => StandardRoom; set => StandardRoom = value; }
        public override void CreateReservation()
        {
            throw new NotImplementedException();
        }
        public override void DeleteReservation()
        {
            throw new NotImplementedException();
        }
       
    }
}
