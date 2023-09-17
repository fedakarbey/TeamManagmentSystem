using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamManagment.UI.Models.Core.Entites;
using TeamManagment.UI.Models.DAL.Concrete;

namespace TeamManagment.UI.Models.DAL.Interfaces
{
    public interface ITakimKisiDAL
    {
        public List<TakimKisi> TakimUyeliniGetir(int takimID);
        public bool TakimdanKisiCikart(int kisiID);
        public bool TakimaKisiEkle(int kisiID, int takimID);
    }
}
