using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce_System.Modles
{
    internal class User
    {
        public int userId { get; set; } //System Generated
        public string userName { get; set; } //User input
        public string email { get; set; } // User input 
        public string passwordHash { get; set; } //User input
        public string fullName { get; set; }// User input
        public string phoneNumber { get; set; } // user input
        public string address { get; set; } // user input
        public DateTime registrationDate { get; set; } //calculated
        public bool isActive { get; set; } //Default



    }
}
