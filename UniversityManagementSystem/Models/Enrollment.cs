using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniversityManagementSystem.Models
{
    internal class Enrollment
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int enrollmentId { get; set; } //System Generated


        [ForeignKey("Student")]
        public int studentId { get; set; } //From list/foreign key
        public Student Student { get; set; }
       

        [ForeignKey("Course")] 
        public int courseId { get; set; } //From list/foreign key
        public Course course { get; set; } 

        [Required]
        public DateTime enrollmentDate { get; set; } //Calculated

        [MaxLength(2)]
        public string? finalGrade { get; set; } //Calculated
        [Required]

        [MaxLength(20)]
        public string status { get; set; } = "In Progress"; //  Default Value
    }
}
