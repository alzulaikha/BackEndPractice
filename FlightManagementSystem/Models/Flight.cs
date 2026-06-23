using System;
using System.Collections.Generic;
using System.Text;

namespace FlightManagementSystem.Models
{
    public class Flight
    {
        public int flightId { get; set; }
        public string flightCode { get; set; }

        public int aircraftId;
        public int pilotId;
        public string origin { get; set; }
        public string destination { get; set; }
        public string departureTime { get; set; }
        public decimal ticketPrice { get; set; }
        public int availableSeats { get; set; }
        public string status { get; set; }
    }
}
