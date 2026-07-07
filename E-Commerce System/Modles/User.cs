using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;
namespace E_Commerce_System.Modles
{
    [Index(nameof(userName), IsUnique = true)]
    [Index(nameof(email), IsUnique = true)]

    public class User
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int userId { get; set; } //System Generated

        [Required]
        [MaxLength(50)]

        public string userName { get; set; } //User input
        [Required]
        [MaxLength(150)]
        public string email { get; set; } // User input 
        [Required]
        [MaxLength(256)]
        public string passwordHash { get; set; } //User input
        [Required]
        [MaxLength(100)]
        public string fullName { get; set; }// User input
        [MaxLength(20)]
        public string? phoneNumber { get; set; } // user input
        [MaxLength(300)]
        public string? address { get; set; } // user input
        [Required]
        public DateTime registrationDate { get; set; } //calculated
        public bool isActive { get; set; } = true; //Default


        public List<Order> Orders { get; set; } //navigation — one User places many Orders
        public List<Review> Reviews { get; set; } 
    }
}
