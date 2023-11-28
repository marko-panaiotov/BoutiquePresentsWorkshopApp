using System;
using BPW.Data.Entities;

namespace BoutiquePresentsWorkshop.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }
}

