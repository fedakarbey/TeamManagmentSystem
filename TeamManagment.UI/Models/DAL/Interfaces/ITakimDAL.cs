﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamManagment.UI.Models.Core.Entites;

namespace TeamManagment.UI.Models.DAL.Interfaces
{
    public interface ITakimDAL
    {
        List<Takim> TakimGetir();
    }
}
