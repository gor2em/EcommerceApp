﻿using Ecommerce.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.BLL.Abstraction
{
    public interface IShopManager:IManager<Shop>
    {
        void LoadProduct(Shop shop);
    }
}
