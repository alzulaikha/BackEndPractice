using System;
using System.Collections.Generic;
using System.Text;

namespace FlightManagementSystem.Models
{
    public class Pilot
    {
        public int pilotId { get; set; } //System Generated
        public string pilotName { get; set; }//User input
        public string pilotPhone { get; set; } //User input

        public string licenseNumber { get; set; } //User input
        public int flightHours { get; set; } //Calculated
        public bool isAvailable { get; set; } //Default Value
    }
}
