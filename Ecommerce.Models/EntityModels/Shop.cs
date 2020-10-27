using Ecommerce.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Models.EntityModels
{
    public class Shop : IDeleteable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool IsDeleted { get; set; }
        public int? DeletedById { get; set; }
        public DateTime? DeletedOn { get; set; }
        public string DeleteRemarks { get; set; }
        public Shop()//ctor da productların oluşmasını istiyoruz.
        {
            Products = new List<Product>();
        }

        public virtual ICollection<Product> Products { get; set; }
    }
}
