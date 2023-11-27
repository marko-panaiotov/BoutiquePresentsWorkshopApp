using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPW.Data.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public double Price { get; set; }

        [ValidateNever]
        //[NotMapped]
        public string ImageUrl { get; set; }

        public int CategoryId { get; set; }

        [ValidateNever]
        //[NotMapped]
        public Category Category { get; set; }


    }
}
