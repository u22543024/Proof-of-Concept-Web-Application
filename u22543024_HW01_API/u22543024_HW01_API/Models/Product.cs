using System.ComponentModel.DataAnnotations;

namespace u22543024_HW01_API.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
