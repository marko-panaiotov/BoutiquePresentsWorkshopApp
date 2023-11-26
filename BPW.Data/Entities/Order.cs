using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPW.Data.Entities
{
    [Table("Order")]
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }= DateTime.UtcNow;

        public bool IsDeleted { get; set; }= false;

        [Required]
        public int OrderStatus { get; set; }
        [ForeignKey("OrderStatusID")]
        public OrderStatus orderStatus { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
