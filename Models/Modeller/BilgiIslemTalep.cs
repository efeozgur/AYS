using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AYS.Models.Modeller
{
    [Table("BilgiIslemTalep")]
    public class BilgiIslemTalep
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(50), Required]
        public string talepBaslik { get; set; }
        [StringLength(5000), Required]
        public string talep { get; set; }
        [StringLength(10), Required]
        public string talepTarihi { get; set; }
        public bool talepDurumu { get; set; }
    }
}