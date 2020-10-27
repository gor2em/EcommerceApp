using Ecommerce.Models.DTO;
using Ecommerce.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.BLL.Abstraction.Contracts
{
    public interface IProductManager:IManager<Product>
    {
        ICollection<Product> Search(ProductSearchCriteriaDTO dto);
        ICollection<Product> GetShopId(int shopId);
    }
}
