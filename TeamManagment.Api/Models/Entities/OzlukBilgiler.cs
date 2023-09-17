using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamManagment.Api.Models.Entities
{
    public partial class OzlukBilgiler
    {
        [Key]
        public int KisiID { get; set; }
        public string TCNo { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public long? TelefonNo { get; set; }
    }
}
