using System.ComponentModel.DataAnnotations;

namespace ProductRegistrationAndListing.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductDescription { get; set; }
        public decimal Value { get; set; }
        public bool AvailableForSell { get; set; }
    }
}
