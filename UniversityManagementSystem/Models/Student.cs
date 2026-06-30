using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityManagementSystem.Models
{
    internal class Student
    {
        
        public int studentId { get; set; } //System Generated
        public string fullName { get; set; } //User Input
        public string email { get; set; } // User Input
        public string phoneNumber { get; set; } // User Input
        public DateTime dateOfBirth { get; set; } //Calculated
        public int enrollmentYear { get; set; } // User Input
        public decimal gpa { get; set; } // Calculated

    }
}
