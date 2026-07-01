using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce_System.Modles
{
    internal class Order
    {
        public int orderId { get; set; } //System Generated
        public int userId { get; set; } //From list/forgin key
        public DateTime orderDate { get; set; } //calculated
        public decimal totalAmount { get; set; } //calculated
        public bool status { get; set; } //Default
        public string shippingAddress { get; set; } // user input
        public string paymentMethod { get; set; } //user input
 
    }
}
