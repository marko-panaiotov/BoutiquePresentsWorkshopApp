using System;
using BPW.Data.Entities;

namespace BoutiquePresentsWorkshop.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);

    }
}

