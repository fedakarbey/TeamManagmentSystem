using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamManagment.Api.Models.DTOs
{
    public class KisiBilgiDTO
    {
        public int KisiID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TCNo { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public long? TelefonNo { get; set; }
    }
}
