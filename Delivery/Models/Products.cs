using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.Models
{
    public class Products
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ProductsId { get; set; }

        public string Name { get; set; }

        public long Cost { get; set; }

        public virtual ICollection<Bascket> Basckets { get; set; }
    }
}
