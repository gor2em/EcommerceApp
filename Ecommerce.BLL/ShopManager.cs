using Ecommerce.BLL.Abstraction.Base;
using Ecommerce.BLL.Abstraction.Contracts;
using Ecommerce.Models.EntityModels;
using Ecommerce.Repository.Abstraction.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.BLL
{
    public class ShopManager : Manager<Shop>, IShopManager
    {
        private IShopRepository _shopRepository;
        public ShopManager(IShopRepository shopRepository) : base(shopRepository)
        {
            _shopRepository = shopRepository;
        }

        public bool Add(Shop entity)
        {
            throw new NotImplementedException();
        }

        public void LoadProduct(Shop shop)
        {
            _shopRepository.LoadProduct(shop);
        }
    }
}
