using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;
namespace E_Commerce_System.Modles
{
    [Index(nameof(categoryName), IsUnique = true)]
    public class Category
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int categoryId { get; set; } //System Generated
        [Required]
        [MaxLength(100)]
        public string categoryName { get; set; } //User input 
        [MaxLength(500)]
        public string? description { get; set; } // User input /Optional
        [MaxLength(300)]
        public string? imageUrl { get; set; } //User input  /Optional


        public List<Product> Products { get; set; }  // navigation — one Category has many Products

    }
}


