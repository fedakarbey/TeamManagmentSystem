using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamManagment.UI.Models.Core.Entites
{
    public partial class Unvan
    {
        public Unvan()
        {
            Kisi = new HashSet<Kisi>();
        }

        public int UnvanID { get; set; }

        [StringLength(50)]
        public string UnvanAdi { get; set; }

        public virtual ICollection<Kisi> Kisi { get; set; }
    }
}
