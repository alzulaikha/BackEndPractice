using System;
using System.Collections.Generic;
using System.Text;

namespace FlightManagementSystem.Models
{
    public class Aircraft
    {
        public int aircraftId { get; set; } //System Generated
        public string model { get; set; }// User input (Aircraft model name (e.g. Boeing 737, Airbus A320))
        public int totalSeats { get; set; } //User input
        public bool isOperational { get; set; } //Default Value
    }
}
