using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Models
{
    public class ProductOrders
    {
        [Key]
        public int Id { get; set; }
        public int OrderId { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product product { get; set; }

    }
}
