using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityManagementSystem.Models
{
    internal class Department
    {
        public int departmentId { get; set; } //System Generated
        public string departmentName { get; set; } //User Input
        public string building { get; set; } // User Input
        public decimal budget { get; set; } //Calculated
        public int headInstructorId { get; set; } //From list/foreign key

    }
}
