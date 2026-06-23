using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace FlightManagementSystem.Models
{
    public class Passenger
    {

        public int passengerId { get; set; } 
        public string passengerName { get; set; } 
        public string passengerEmail { get; set; } //Email address used for booking confirmation

        public string passengerPhone { get; set; }        
        public string passportNumber { get; set; } // Passport / national ID number — must be unique per passenger
        public string nationality { get; set; } 

    
    }
}
