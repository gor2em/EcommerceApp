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
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        private EcommerceDatabaseContext _db;
        public CustomerRepository(EcommerceDatabaseContext db) : base(db)
        {
            _db = db;
        }
    }
}
