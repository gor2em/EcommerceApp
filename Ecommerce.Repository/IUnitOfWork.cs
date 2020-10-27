using Ecommerce.Repository.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Repository
{
    //IUnitOfWork: I love you database.
    public interface IUnitOfWork
    {
        ProductRepository ProductRepository { get; }
        bool SaveChange();
    }
}
