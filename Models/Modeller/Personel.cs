using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AYS.Models.Modeller
{
    [Table("Personel")]
    public class Personel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(100), Required]
        public string adSoyad { get; set; }
        [StringLength(8), Required]
        public string sicilNo { get; set; }
        [StringLength(11), Required]
        public string cepTelefonu { get; set; }
        [StringLength(5)]
        public string dahiliNo1 { get; set; }
        [StringLength(5)]
        public string dahiliNo2 { get; set; }
        public bool durumu { get; set; }


    }
}