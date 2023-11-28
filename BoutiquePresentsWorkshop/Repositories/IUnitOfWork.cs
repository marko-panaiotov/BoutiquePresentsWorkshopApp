using System;
namespace BoutiquePresentsWorkshop.Repositories
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        IProductRepository Product { get; }
        //ICartRepository Cart{get;}
        //IApplicationUser ApplicationUser{get;}
        //IOrderHeaderRepository OrderHeader{get;}
        //IOrderDetailRepository OrderDetail{get;}
        void Save();
    }
}

