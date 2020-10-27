using Ecommerce.Models.DTO;
using Ecommerce.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Repository.Abstraction.Contracts
{
    public interface IProductRepository:IRepository<Product>
    {
        //custom operation
        ICollection<Product> Search(ProductSearchCriteriaDTO dto);
        ICollection<Product> GetShopId(int shopId);

    }
}
