using System;
using System.Collections.Generic;
using System.Text;

namespace FlightManagementSystem.Models
{
    public class Booking
    {
        public int bookingId { get; set; }
        public int passengerId;

        public int flightId;
        public int pilotId;
        public string seatNumber { get; set; }
        public string bookingDate { get; set; }
        public string departureTime { get; set; }
        public decimal totalPrice { get; set; }
        public string status { get; set; }
    }
}
