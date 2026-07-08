using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_Commerce_System.Modles
{
    public class Order
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int orderId { get; set; } //System Generated
        
        [Required]
        [ForeignKey("User")]
        public int userId { get; set; } //From list/forgin key
        public User User { get; set; }

        [Required]
        public DateTime orderDate { get; set; } //calculated

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        [Range(0, double.MaxValue)]
        public double totalAmount { get; set; } //calculated

        [Required]
        [MaxLength(30)]
        public string status { get; set; } = "Pending";//Default

        [Required]
        [MaxLength (300)]
        public string shippingAddress { get; set; } // user input

        [Required]
        [MaxLength(50)]
        public string paymentMethod { get; set; } //user input



        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    }
}
