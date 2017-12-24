using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        public int OrderIDP { get; set; }

        [Key]
        public int ProductID { get; set; }

        public int Quantity { get; set; }

        [ForeignKey("OrderID")]
        public virtual Order Oder { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }
    }
}