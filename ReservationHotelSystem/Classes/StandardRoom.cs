using System;
using System.Collections.Generic;
using System.Text;

namespace ReservationHotelSystem.Classes
{
    internal class StandardRoom : IRoom
    {
        public StandardRoom()
        {
            components = new List<Components>();
            building = new Building();
        }
        public int id { get; set; }
        public List<Components> components { get; set; }    // changed from Components to List<Components>
        public string facilities { get; set; }
        public decimal price { get; set; }
        public Building building { get; set; }              // added to implement IRoom

        public void Clean() { }
        public void IsAvalible() { }
        public void CheckIn() { }
        public void CheckOut() { }
    }
}
