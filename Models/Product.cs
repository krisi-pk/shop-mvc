using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}
