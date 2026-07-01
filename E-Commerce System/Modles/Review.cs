using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce_System.Modles
{
    internal class Review
    {
        public int reviewId { get; set; } //System Generated
        public int userId { get; set; } //From list/forgin key
        public int productId { get; set; } //From list/forgin key
        public int rating { get; set; } //calculated
        public string comment { get; set; } //user input
        public DateTime reviewDate { get; set; } //calculated

    }
}
