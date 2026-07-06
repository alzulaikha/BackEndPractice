using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_Commerce_System.Modles
{
    internal class Order
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
        [Range(0,decimal.MaxValue)]
        public decimal totalAmount { get; set; } //calculated

        [Required]
        [MaxLength(30)]
        public bool status { get; set; } = "Pending";//Default

        [Required]
        [MaxLength (300)]
        public string shippingAddress { get; set; } // user input

        [Required]
        [MaxLength(50)]
        public string paymentMethod { get; set; } //user input



        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    }
}
