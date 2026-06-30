using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniversityManagementSystem.Models
{
    [Index(nameof(departmentName), IsUnique = true)]
    internal class Department
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int departmentId { get; set; } //System Generated
        [Required]
        [MaxLength(100)]
        public string departmentName { get; set; } //User Input
        [MaxLength(50)]
        public string? building { get; set; } // User Input, Optional
        [Required]
        [Range(0, double.MaxValue)]  //greater than or equal to 0
        public decimal budget { get; set; } //Calculated
        [ForeignKey("Instructor")] //Foreign Key to Instructor
        public int headInstructorId { get; set; } //From list/foreign key
        public Instructor Instructor { get; set; }

    }
}
