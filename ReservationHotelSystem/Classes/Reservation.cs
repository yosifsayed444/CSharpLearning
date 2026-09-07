using System;
using System.Collections.Generic;
using System.Text;

namespace ReservationHotelSystem.Classes
{
    public abstract class Reservation
    {
        public Reservation()
        {
            FromDate = DateTime.Now;
            Customer = new Customer();
        }
        
        public int Id { get; set; }
        public Customer Customer { get; set; } 
        public virtual IRoom room { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public virtual void CreateReservation()
        {
            // Implementation for creating a reservation
        }
        public void EditReservation()
        {
            // Implementation for editing a reservation
        }
        public void CancelReservation()
        {
            // Implementation for canceling a reservation
        }
        public abstract void DeleteReservation();
        
    }
}
