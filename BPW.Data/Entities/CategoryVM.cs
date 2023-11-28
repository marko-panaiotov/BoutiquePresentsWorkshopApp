using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace BPW.Data.Entities
{
    [Keyless]
    public class CategoryVM
    {
        
        public Category Category { get; set; } = new Category();
        public IEnumerable<Category> categories { get; set; } = new List<Category>();
    }
}

