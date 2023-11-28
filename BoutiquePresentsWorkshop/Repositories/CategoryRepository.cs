using System;
using BoutiquePresentsWorkshop.Data;
using BPW.Data.Entities;

namespace BoutiquePresentsWorkshop.Repositories
{
    public class CategoryRepository:Repository<Category>,ICategoryRepository
    {

        private ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void Update(Category category)
        {
            var categoryDB = _context.Categories.FirstOrDefault(x => x.Id == category.Id);
            if (categoryDB != null)
            {
                categoryDB.CategoryName = category.CategoryName;
                categoryDB.DisplayOrder = category.DisplayOrder;
            }
        }
    }
}

