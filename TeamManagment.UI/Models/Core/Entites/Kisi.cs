using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamManagment.UI.Models.Core.Entites
{
    public partial class Kisi
    {
        public Kisi()
        {
            TakimKisi = new HashSet<TakimKisi>();
        }

        [Key]
        public int KisiID { get; set; }

        [StringLength(50)]
        public string Ad { get; set; }

        [StringLength(50)]
        public string Soyad { get; set; }

        public int? UnvanID { get; set; }

        public virtual Unvan Unvan { get; set; }

        public virtual OzlukBilgiler OzlukBilgiler { get; set; }

        public virtual ICollection<TakimKisi> TakimKisi { get; set; }
    }
}
