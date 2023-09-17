using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamManagment.Api.Models.Entities;

namespace TeamManagment.Api.Models.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
        {

        }
        public MyDbContext(DbContextOptions opt) : base(opt)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<OzlukBilgiler> OzlukBilgiler { get; set; }
        public virtual DbSet<Kisi> Kisi { get; set; }
    }
}
