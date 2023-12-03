using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoutiquePresentsWorkshop.Models
{
    public class Order
    {

        public Order()
        {
            OrderDetails=new List<OrderDetails>();
        }
        public int Id { get; set; }
        [Display(Name = "Order No")]
        public string OrderNo { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Phone No")]
        public string PhoneNo { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime OrderDate { get; set; } = DateTime.Now;

        public virtual List<OrderDetails> OrderDetails { get; set; }
    }
}
