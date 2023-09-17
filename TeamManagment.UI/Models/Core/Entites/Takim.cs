using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamManagment.UI.Models.Core.Entites
{
    public partial class Takim
    {
        public Takim()
        {
            TakimKisi = new HashSet<TakimKisi>();
        }

        public int TakimID { get; set; }

        [StringLength(50)]
        public string TakimAdi { get; set; }

        public virtual ICollection<TakimKisi> TakimKisi { get; set; }
    }
}
