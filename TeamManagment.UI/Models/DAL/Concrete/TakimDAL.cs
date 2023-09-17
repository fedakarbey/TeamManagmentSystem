using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamManagment.UI.Models.Core.Context;
using TeamManagment.UI.Models.Core.Entites;
using TeamManagment.UI.Models.DAL.Interfaces;

namespace TeamManagment.UI.Models.DAL.Concrete
{
    public class TakimDAL : ITakimDAL
    {
        private readonly MyDBContext _context;
        public TakimDAL(MyDBContext context)
        {
            _context = context;
        }

        public List<Takim> TakimGetir()
        {
            return _context.Takim.ToList();
        }
    }
}
