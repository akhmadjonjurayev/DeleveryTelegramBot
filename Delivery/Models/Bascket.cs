using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.Models
{
    public class Bascket
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid BasketId { get; set; }

        [ForeignKey("Products")]
        public Guid ProductID { get; set; }

        [ForeignKey("User")]
        public Guid BotUserID { get; set; }

        public int Count { get; set; }

        public EntityState EntityState { get; set; }

        public virtual BotUser User { get; set; }

        public virtual Products Products { get; set; }
    }
}
