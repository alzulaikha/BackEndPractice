using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_Commerce_System.Modles { 

    public class Product
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int productId { get; set; } //System Generated

        [Required]
        [MaxLength(150)]
        public string productName { get; set; } //User input

        [MaxLength(1000)]
        public string? description { get; set; } // User input 

        [Required,]
        [Column(TypeName = "decimal(10,2)")] 
        [Range(0.01,double.MaxValue)]
        public double price { get; set; } //User input

        [Required]
        [Range(0, int.MaxValue)] //must be greater than or equal to 0
        public int stockQuantity { get; set; } = 0;//calculated

        [MaxLength(300)]
        public string? imageUrl { get; set; } // user input,  Optional

        [Required]
        [ForeignKey(" Category")]
        public int categoryId { get; set; } //  From List/ forgin key
        public Category Category { get; set; }

        [Required]
        public DateTime createdAt { get; set; } //calculated
        public bool isAvailable { get; set; } = true; //Default


      public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>(); // navigation — one Product has many Reviews
        public List<Review> Reviews { get; set; } = new List<Review>(); //navigation — one Product appears in many OrderItems (bridge table)

}
}
