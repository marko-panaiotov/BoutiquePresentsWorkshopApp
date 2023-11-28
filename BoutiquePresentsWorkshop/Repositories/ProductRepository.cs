using System;
using BoutiquePresentsWorkshop.Data;
using BPW.Data.Entities;

namespace BoutiquePresentsWorkshop.Repositories
{
    public class ProductRepository : Repository<Product>,IProductRepository
    {
        private ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context):base(context)
        {
            _context = context;
        }

        public void Update(Product product)
        {
            var productDB = _context.Products.FirstOrDefault(x => x.Id == product.Id);
            if (productDB != null)
            {
                productDB.ProductName = product.ProductName;
                productDB.Description = product.Description;
                productDB.Price = product.Price;
                if (product.ImageUrl != null)
                {
                    productDB.ImageUrl = product.ImageUrl;
                }
            }
        }
    }
}

