using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.Models
{
    public class BotButton
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid BotButtonId { get; set; }

        [ForeignKey("Menu")]
        public Guid MenuVersionID { get; set; }

        public string Identifier { get; set; }

        public virtual MenuVersion Menu { get; set; }
    }
}
