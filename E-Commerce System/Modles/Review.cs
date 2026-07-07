using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_Commerce_System.Modles
{
    public class Review
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int reviewId { get; set; } //System Generated

        [Required]
        [ForeignKey("user")]
        public int userId { get; set; } //From list/forgin key
        public User user { get; set; }


        [Required]
        [ForeignKey("product")]
        public int productId { get; set; } //From list/forgin key
        public Product product { get; set; }

        [Required]
        [Range(1, 5)]
        public int rating { get; set; } //calculated

        [MaxLength(1000)]
        public string comment { get; set; } //user input

        [Required]
        public DateTime reviewDate { get; set; } //calculated

    }
}
