using Ecommerce.Models.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ecommerce.Models.EntityModels
{
    public class Product:IDeleteable
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="bu alan zorunlu")]
        public string Name { get; set; }
        [StringLength(11)]
        public string Code { get; set; }
        public double Price { get; set; }
        public string WarehouseLocation { get; set; }
        public int? ShopId { get; set; }
        public Shop Shop { get; set; }
        public bool IsDeleted { get; set; }
        public int? DeletedById { get; set; }
        public DateTime? DeletedOn { get; set; }
        public string DeleteRemarks { get; set; }

    }
}
