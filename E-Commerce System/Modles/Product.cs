using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce_System.Modles
{
    internal class Product
    {
        public int productId { get; set; } //System Generated
        public string productName { get; set; } //User input
        public string description { get; set; } // User input 
        public decimal price { get; set; } //User input
        public int stockQuantity { get; set; }//calculated
        public string imageUrl { get; set; } // user input
        public int categoryId { get; set; } //  From List/ forgin key
        public DateTime createdAt { get; set; } //calculated
        public bool isAvailable { get; set; } //Default
    }
}
