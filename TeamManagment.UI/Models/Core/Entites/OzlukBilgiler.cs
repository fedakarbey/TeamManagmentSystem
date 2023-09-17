using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamManagment.UI.Models.Core.Entites
{
    public partial class OzlukBilgiler
    {
        [Key]
        public int KisiID { get; set; }

        [StringLength(50)]
        public string TCNo { get; set; }

        public DateTime? DogumTarihi { get; set; }

        public long? TelefonNo { get; set; }

        public virtual Kisi Kisi { get; set; }
    }
}
