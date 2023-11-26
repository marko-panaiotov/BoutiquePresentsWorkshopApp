using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPW.Data.Entities
{
    [Table("Category")]
    public class Category
    {

        [Key]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        [Display(Name = "Име на категория")]
        public string CategoryName { get; set; }
    }
}
