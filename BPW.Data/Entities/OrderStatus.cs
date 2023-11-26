using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPW.Data.Entities
{
    [Table("OrderStatus")]
    public class OrderStatus
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int StatusId { get; set; }

        [Required]
        [MaxLength(30)]
        public string OrderStatusName { get; set;}
    }
}
