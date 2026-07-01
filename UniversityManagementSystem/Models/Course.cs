using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniversityManagementSystem.Models
{
    [Index(nameof(courseCode), IsUnique = true)]
    internal class Course
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int courseId { get; set; } //System Generated
        [Required]
        [MaxLength(10)]
        public string courseCode { get; set; } //System Generated
        [Required]
        [MaxLength(150)]
        public string courseTitle { get; set; } // User Input
        [Required]
        [Range(1, 6)]
        public int creditHours { get; set; } //Calculated
        [ForeignKey("Department")]
        public int departmentId { get; set; }  //From list/foreign key
        public Department Department { get; set; }

        [ForeignKey("Instructor")]
        public int instructorId { get; set; }  //From list/foreign key
        public Instructor Instructor { get; set; }

        [Required]
        [MaxLength(20)]
        public string semesterOffered { get; set; } // User Input

        public ICollection<Enrollment> Enrollment { get; set; } // Navigation property 

    }
}
