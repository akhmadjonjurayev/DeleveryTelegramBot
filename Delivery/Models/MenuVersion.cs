using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.Models
{
    public class MenuVersion
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid MenuVersionId { get; set; }

        public string MenuName { get; set; }

        public int Version { get; set; }

        public ICollection<BotButton> BotButtons { get; set; }
    }
}
