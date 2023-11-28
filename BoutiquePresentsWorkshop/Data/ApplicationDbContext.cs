using BPW.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BoutiquePresentsWorkshop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<BPW.Data.Entities.CategoryVM> CategoryVM { get; set; } = default!;
        //public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        //public DbSet<Cart> Carts { get; set; }
       // public DbSet<OrderHeader> OrderHeaders { get; set; }
       // public DbSet<OrderDetail> OrderDetails { get; set; }



    }
}
