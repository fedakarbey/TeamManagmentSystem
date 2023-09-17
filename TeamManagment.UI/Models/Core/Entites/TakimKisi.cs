using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamManagment.UI.Models.Core.Entites
{
    public partial class TakimKisi
    {
        public int TakimKisiID { get; set; }

        public int? TakimID { get; set; }

        public int? KisiID { get; set; }

        public virtual Kisi Kisi { get; set; }

        public virtual Takim Takim { get; set; }
    }
}
