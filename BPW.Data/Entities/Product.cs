using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPW.Data.Entities
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 1)]
        [Display(Name = "Име")]
        public string ProductName { get; set; }

        [Required]
        [StringLength(500, MinimumLength = 1)]
        [Display(Name = "Описание")]
        public string ProductDescription { get; set; }

        [Required]
        [Display(Name = "Цена")]
        public decimal Price { get; set; }
        [Display(Name = "Снимка")]
        public string Image { get; set; }

        [Required]
        [Display(Name = "Наличност")]
        public bool IsAvailable { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [Display(Name = "Категория")]
        public Category Category{ get; set; }

        public List<OrderDetail> OrderDetail { get; set; }
        public List<CartDetail> CartDetail { get; set; }
    }
}
