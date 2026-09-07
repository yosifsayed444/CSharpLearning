using System;
using System.Collections.Generic;
using System.Text;

namespace ReservationHotelSystem.Classes
{
    internal class VipReservation : Reservation
    {
        private IRoom VipRoom;
        public override IRoom room { get => VipRoom; set => VipRoom = value; }
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

