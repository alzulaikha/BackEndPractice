using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityManagementSystem.Models
{
    internal class Course
    {
        public int courseId { get; set; } //System Generated
        public string courseCode { get; set; } //System Generated
        public string courseTitle { get; set; } // User Input
        public int creditHours { get; set; } //Calculated
        public int departmentId { get; set; }  //From list/foreign key
        public int instructorId { get; set; }  //From list/foreign key
        public string semesterOffered { get; set; } // User Input
    }
}
