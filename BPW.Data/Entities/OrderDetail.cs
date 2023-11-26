using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPW.Data.Entities
{
    [Table("OrderDetail")]
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int OrderId { get; set; }

        [Required]
        public int ProductID { get; set; }
        
        [Required] 
        public int Quantity { get; set; }

        [Required]
        public decimal UnitPrice { get; set; }

        public Order Order { get; set; }

        public Product Product { get; set; }
        
    }
}
