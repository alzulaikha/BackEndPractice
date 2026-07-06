using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_Commerce_System.Modles
{
    internal class OrderItem
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






    }
}
