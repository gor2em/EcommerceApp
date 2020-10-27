using Ecommerce.BLL.Abstraction.Base;
using Ecommerce.BLL.Abstraction.Contracts;
using Ecommerce.Models.EntityModels;
using Ecommerce.Repository.Abstraction.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.BLL
{
    public class PurchesOrderManager : Manager<PurchesOrder>, IPurchesOrderManager
    {
        IPurchesOrderRepository _purchesOrderRepository;
        public PurchesOrderManager(IPurchesOrderRepository purchesOrderRepository) : base(purchesOrderRepository)
        {
            _purchesOrderRepository = purchesOrderRepository;
        }

        public bool Add(PurchesOrder entity)
        {
            throw new NotImplementedException();
        }
    }
}
