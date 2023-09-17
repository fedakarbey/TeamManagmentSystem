using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamManagment.UI.Models.Core.Context;
using TeamManagment.UI.Models.Core.Entites;
using TeamManagment.UI.Models.DAL.Interfaces;

namespace TeamManagment.UI.Models.DAL.Concrete
{
    public class KisiDAL : IKisiDAL
    {

        private readonly MyDBContext _context;
        public KisiDAL(MyDBContext context)
        {
            _context = context;
        }
        
        public List<Kisi> KisiGetir()
        {
            return _context.Kisi.ToList();
        }

        public List<Kisi> KisiGetir(int unvanID)
        {
           return _context.Kisi.Where(a => a.Unvan.UnvanID == unvanID && !a.TakimKisi.Any()).ToList();
        }
    }
}
