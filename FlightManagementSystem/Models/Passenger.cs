using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace FlightManagementSystem.Models
{
    public class Passenger
    {

        public int passengerId { get; set; } //System Generated
        public string passengerName { get; set; } //User input
        public string passengerEmail { get; set; } //User input 

        public string passengerPhone { get; set; } //User input       
        public string passportNumber { get; set; } //User input ( Passport / national ID number — must be unique per passenger)
        public string nationality { get; set; } //User input

    
    }
}
