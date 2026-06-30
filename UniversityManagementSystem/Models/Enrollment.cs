using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityManagementSystem.Models
{
    internal class Enrollment
    {
        public int enrollmentId { get; set; } //System Generated
        public int studentId { get; set; } //From list/foreign key
        public int courseId { get; set; } //From list/foreign key
        public DateTime enrollmentDate { get; set; } //Calculated
        public string finalGrade { get; set; } //Calculated
        public string status { get; set; } //  Default Value
    }
}
