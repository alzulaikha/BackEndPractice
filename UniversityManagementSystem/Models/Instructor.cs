using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniversityManagementSystem.Models
{
    [Index(nameof(email), IsUnique = true)]
    internal class Instructor
    {

        [Key]
        [Required]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int instructorId { get; set; } //System Generated
        [Required]
        [MaxLength(100)]
        public string fullName { get; set; } //User Input
        [Required]
        [MaxLength(150)]
        public string email { get; set; } // User Input
        [MaxLength(20)]
        public string? officeNumber { get; set; } //System Generated
        [Required]
        public DateTime hireDate { get; set; } // User Input
        [Required]

        public decimal salary { get; set; } // Calculated
        [Required]
        [MaxLength(50)]
        public string academicTitle { get; set; } // User Input





    }
}
