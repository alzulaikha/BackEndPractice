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




 


    }
}
