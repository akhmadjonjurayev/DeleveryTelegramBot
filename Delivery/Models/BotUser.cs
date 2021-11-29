using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.Models
{
    public class BotUser
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid BotUserId { get; set; }

        public long UserId { get; set; }

        public string UserName { get; set; }

        public virtual ICollection<Bascket> Basckets { get; set; }
    }
}
