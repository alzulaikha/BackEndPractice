using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_Commerce_System.Modles
{
    public class OrderItem
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int orderItemId { get; set; } // system generated


        //  relationship carries the attribute 'quantity' 
        [Required]
        [Range(1, 999)]
        public int quantity { get; set; }// user input


        // foreign key — every order item belongs to exactly one order
        [Required]
        [ForeignKey("Order")]
        public int orderId { get; set; }// system generated 
        public Order Order { get; set; }// navigation property


        // foreign key — every order item references exactly one product
        [Required]
        [ForeignKey("Product")]
        public int productId { get; set; }// from list 
        public Product Product { get; set; }// navigation property




        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public double unitPrice { get; set; }  // calculated — copied from product.price at the time of ordering

    }
}
