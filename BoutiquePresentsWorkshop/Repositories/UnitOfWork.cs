using System;
using BoutiquePresentsWorkshop.Data;

namespace BoutiquePresentsWorkshop.Repositories
{
    public class UnitOfWork:IUnitOfWork
    {
        private ApplicationDbContext _context;
        public ICategoryRepository Category { get; private set; }
        public IProductRepository Product { get; private set; }
        //public ICartRepository Cart{get;private set;private set;}
        //public IApplicationUser ApplicationUser{get;private set;}
        //public IOrderHeaderRepository OrderHeader{get;private set;}
        //public IOrderDetailRepository OrderDetail{get;private set;}
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Category = new CategoryRepository(context);
            Product = new ProductRepository(context);
            //Cart = new CartRepository(context);
            //ApplicationUser =new ApplicationRepositiry(context);
            //OrderDetail = new OrderDEtailRepositiry(context);
            //OrderHeader=new OrderHeaderRepository(context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

    }
}

