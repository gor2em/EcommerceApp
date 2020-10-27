using Ecommerce.DatabaseContext.DatabaseContext;
using Ecommerce.Models.EntityModels;
using Ecommerce.Repository.Abstraction.Base;
using Ecommerce.Repository.Abstraction.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Repository.Products
{
    public class ShopRepository : Repository<Shop>, IShopRepository
    {
        private EcommerceDatabaseContext _db;
        public ShopRepository(DbContext db) : base(db)
        {
            _db = db as EcommerceDatabaseContext;
        }

        public void Update(Shop entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
        }
        public void LoadProduct(Shop shop)
        {
            _db.Entry(shop).Collection(c => c.Products).reference(c => c.Products).Load();
        }
    }
}
