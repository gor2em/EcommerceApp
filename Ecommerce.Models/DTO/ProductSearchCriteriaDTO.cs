using Ecommerce.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Models.DTO
{
    public class ProductSearchCriteriaDTO
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public double FromSalesPrice { get; set; }
        public double ToSalesPrices { get; set; }
        public int ShopId { get; set; }
        public Shop Shop { get; set; }
    }
}
