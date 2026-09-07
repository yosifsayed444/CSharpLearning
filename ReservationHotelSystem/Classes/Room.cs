using System;
using System.Collections.Generic;
using System.Text;

namespace ReservationHotelSystem.Classes
{
    public enum Components
    {
        Bed =1 ,
        TV=2,
        AC=3,
        Fridge=4,
        Balcony=5
    }
    public interface IRoom
    {
      
        public int id { get; set; }
        public List<Components> components { get; set; }
        public string facilities { get; set; }
        public decimal price { get; set; }
        public Building building { get; set; }

        public void Clean();
        public void IsAvalible();
        public void CheckIn();
        public void CheckOut();
 
    }
}
