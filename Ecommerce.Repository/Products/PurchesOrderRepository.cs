using Ecommerce.DatabaseContext.DatabaseContext;
using Ecommerce.Models.EntityModels;
using Ecommerce.Repository.Abstraction.Base;
using Ecommerce.Repository.Abstraction.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecommerce.Repository.Products
{
    public class PurchesOrderRepository : Repository<PurchesOrder>, IPurchesOrderRepository
    {
        private EcommerceDatabaseContext _db;
        public PurchesOrderRepository(DbContext db) : base(db)
        {
            _db = (EcommerceDatabaseContext)db;
        }
        public ICollection<PurchesOrder> GetAll()
        {
            return _db.PurchesOrders.Include(c => c.OrderItems).ToList();
        }
    }
}
