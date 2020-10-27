﻿using Ecommerce.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Repository.Abstraction.Contracts
{
    public interface IShopRepository:IRepository<Shop>
    {
        void LoadProduct(Shop shop);
    }
}
