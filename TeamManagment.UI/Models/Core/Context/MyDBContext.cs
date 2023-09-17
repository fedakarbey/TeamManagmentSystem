using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamManagment.UI.Models.Core.Entites;

namespace TeamManagment.UI.Models.Core.Context
{
    public class MyDBContext : DbContext
    {
        public MyDBContext()
        {

        }
        public MyDBContext(DbContextOptions opt) : base(opt)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //  optionsBuilder.UseSqlServer("Server=.;Database=TeamManagment;uid=sa;pwd=123456");
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Kisi> Kisi { get; set; }
        public virtual DbSet<OzlukBilgiler> OzlukBilgiler { get; set; }
        public virtual DbSet<Takim> Takim { get; set; }
        public virtual DbSet<TakimKisi> TakimKisi { get; set; }
        public virtual DbSet<Unvan> Unvan { get; set; }

        private void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Unvan>().HasData(
             new Unvan
             {
                 UnvanID = 1,
                 UnvanAdi = "Takım Lideri"
             },
            new Unvan
            {
                UnvanID = 2,
                UnvanAdi = "Analist"
            },
             new Unvan
             {
                 UnvanID = 3,
                 UnvanAdi = "Developer"
             },
             new Unvan
             {
                 UnvanID = 4,
                 UnvanAdi = "Tester"
             }
         );
            modelBuilder.Entity<Kisi>().HasData(
             new Kisi
             {
                 KisiID = 1,
                 Ad = "Ali",
                 Soyad = "Erdal",
                 UnvanID = 1
             },
             new Kisi
             {
                 KisiID = 2,
                 Ad = "Mehmet",
                 Soyad = "Bilge",
                 UnvanID = 1
             },
             new Kisi
             {
                 KisiID = 3,
                 Ad = "Doruk",
                 Soyad = "Yurt",
                 UnvanID = 1
             },
             new Kisi
             {
                 KisiID = 4,
                 Ad = "Esra",
                 Soyad = "Ay",
                 UnvanID = 2
             },
             new Kisi
             {
                 KisiID = 5,
                 Ad = "Fatma",
                 Soyad = "Tek",
                 UnvanID = 2
             },
             new Kisi
             {
                 KisiID = 6,
                 Ad = "Leyla",
                 Soyad = "Tepe",
                 UnvanID = 2
             },
              new Kisi
              {
                  KisiID = 7,
                  Ad = "Berke",
                  Soyad = "Atar",
                  UnvanID = 2
              },
             new Kisi
             {
                 KisiID = 8,
                 Ad = "Berk",
                 Soyad = "Tar",
                 UnvanID = 2
             },
             new Kisi
             {
                 KisiID = 9,
                 Ad = "Ali",
                 Soyad = "Uzun",
                 UnvanID = 2
             },
             new Kisi
             {
                 KisiID = 10,
                 Ad = "Sena",
                 Soyad = "İnci",
                 UnvanID = 4
             },
             new Kisi
             {
                 KisiID = 11,
                 Ad = "Bahadır",
                 Soyad = "Tepe",
                 UnvanID = 4
             },
             new Kisi
             {
                 KisiID = 12,
                 Ad = "Yasemin",
                 Soyad = "Tepe",
                 UnvanID = 4
             },
             new Kisi
             {
                 KisiID = 13,
                 Ad = "Mustafa",
                 Soyad = "Hal",
                 UnvanID = 3
             },
             new Kisi
             {
                 KisiID = 14,
                 Ad = "Orhan",
                 Soyad = "Pak",
                 UnvanID = 3
             },
             new Kisi
             {
                 KisiID = 15,
                 Ad = "Neşe",
                 Soyad = "Yılamz",
                 UnvanID = 3
             },
             new Kisi
             {
                 KisiID = 16,
                 Ad = "Hakan",
                 Soyad = "Dur",
                 UnvanID = 3
             },
             new Kisi
             {
                 KisiID = 17,
                 Ad = "Aysun",
                 Soyad = "Toka",
                 UnvanID = 3
             },
             new Kisi
             {
                 KisiID = 18,
                 Ad = "Nermin",
                 Soyad = "Yıldız",
                 UnvanID = 3
             },
             new Kisi
             {
                 KisiID = 19,
                 Ad = "Bahtiyar",
                 Soyad = "Uzun",
                 UnvanID = 3
             },
             new Kisi
             {
                 KisiID = 20,
                 Ad = "Kenan",
                 Soyad = "Soy",
                 UnvanID = 3
             },
             new Kisi
             {
                 KisiID = 21,
                 Ad = "Mazhar",
                 Soyad = "Pak",
                 UnvanID = 3
             },
             new Kisi
             {
                 KisiID = 22,
                 Ad = "Hatice",
                 Soyad = "Pek",
                 UnvanID = 3
             },
             new Kisi
             {
                 KisiID = 23,
                 Ad = "Osman",
                 Soyad = "Yürek",
                 UnvanID = 3
             },
             new Kisi
             {
                 KisiID = 24,
                 Ad = "Sibel",
                 Soyad = "Türk",
                 UnvanID = 3
             },
             new Kisi
             {
                 KisiID = 25,
                 Ad = "Furkan",
                 Soyad = "Aslan",
                 UnvanID = 3
             },
             new Kisi
             {
                 KisiID = 26,
                 Ad = "Tekin",
                 Soyad = "Durmaz",
                 UnvanID = 3
             },
             new Kisi
             {
                 KisiID = 27,
                 Ad = "Özlem",
                 Soyad = "Dal",
                 UnvanID = 3
             }
            );

            modelBuilder.Entity<OzlukBilgiler>().HasData(
                new OzlukBilgiler
                {
                    KisiID = 1,
                    TCNo = "12345678901",
                    DogumTarihi = new DateTime(1991, 2, 13),
                    TelefonNo = 5551234567
                },
                new OzlukBilgiler
                {
                    KisiID = 2,
                    TCNo = "23456789012",
                    DogumTarihi = new DateTime(1992, 3, 16),
                    TelefonNo = 5551234567
                },
                new OzlukBilgiler
                {
                    KisiID = 3,
                    TCNo = "34567890123",
                    DogumTarihi = new DateTime(1987, 4, 10),
                    TelefonNo = 5551234567
                },
                new OzlukBilgiler
                {
                    KisiID = 4,
                    TCNo = "45678901234",
                    DogumTarihi = new DateTime(1992, 8, 24),
                    TelefonNo = 5551234567
                },
                new OzlukBilgiler
                {
                    KisiID = 5,
                    TCNo = "56789012345",
                    DogumTarihi = new DateTime(1987, 3, 14),
                    TelefonNo = 5551234567
                },
                new OzlukBilgiler
                {
                    KisiID = 6,
                    TCNo = "67890123456",
                    DogumTarihi = new DateTime(1997, 5, 25),
                    TelefonNo = 5551234567
                },
                new OzlukBilgiler
                {
                    KisiID = 7,
                    TCNo = "78901234567",
                    DogumTarihi = new DateTime(1993, 10, 10),
                    TelefonNo = 5551234567
                },
                new OzlukBilgiler
                {
                    KisiID = 8,
                    TCNo = "89012345678",
                    DogumTarihi = new DateTime(1991, 7, 7),
                    TelefonNo = 5551234567
                },
                new OzlukBilgiler
                {
                    KisiID = 9,
                    TCNo = "90123456789",
                    DogumTarihi = new DateTime(1991, 2, 3),
                    TelefonNo = 5551234567
                },
                new OzlukBilgiler
                {
                    KisiID = 10,
                    TCNo = "98765432109",
                    DogumTarihi = new DateTime(1994, 11, 22),
                    TelefonNo = 5551234567
                },
                new OzlukBilgiler
                {
                    KisiID = 11,
                    TCNo = "87654321098",
                    DogumTarihi = new DateTime(1996, 5, 11),
                    TelefonNo = 5551234567
                },
                new OzlukBilgiler
                {
                    KisiID = 12,
                    TCNo = "76543210987",
                    DogumTarihi = new DateTime(1985, 4, 16),
                    TelefonNo = 5551234567
                },
                new OzlukBilgiler
                {
                    KisiID = 13,
                    TCNo = "65432109876",
                    DogumTarihi = new DateTime(1994, 4, 13),
                    TelefonNo = 5551234567
                },
                new OzlukBilgiler
                {
                    KisiID = 14,
                    TCNo = "54321098765",
                    DogumTarihi = new DateTime(1990, 5, 13),
                    TelefonNo = 5551234567
                },
                new OzlukBilgiler
                {
                    KisiID = 15,
                    TCNo = "43210987654",
                    DogumTarihi = new DateTime(1990, 8, 18),
                    TelefonNo = 5551234567
                },
                new OzlukBilgiler
                {
                    KisiID = 16,
                    TCNo = "32109876543",
                    DogumTarihi = new DateTime(1990, 11, 21),
                    TelefonNo = 5551234567
                },
                new OzlukBilgiler
                {
                    KisiID = 17,
                    TCNo = "21098765432",
                    DogumTarihi = new DateTime(1996, 12, 27),
                    TelefonNo = 5551234567
                },
                new OzlukBilgiler
                {
                    KisiID = 18,
                    TCNo = "10987654321",
                    DogumTarihi = new DateTime(1984, 7, 9),
                    TelefonNo = 5551234567
                },
                new OzlukBilgiler
                {
                    KisiID = 19,
                    TCNo = "99999999999",
                    DogumTarihi = new DateTime(1982, 6, 8),
                    TelefonNo = 5551234567
                },
                new OzlukBilgiler
                {
                    KisiID = 20,
                    TCNo = "88888888888",
                    DogumTarihi = new DateTime(1993, 4, 4),
                    TelefonNo = 5551234567
                },
                new OzlukBilgiler
                {
                    KisiID = 21,
                    TCNo = "77777777777",
                    DogumTarihi = new DateTime(1995, 2, 10),
                    TelefonNo = 5551234567
                },
                new OzlukBilgiler
                {
                    KisiID = 22,
                    TCNo = "66666666666",
                    DogumTarihi = new DateTime(1989, 1, 30),
                    TelefonNo = 5551234567
                },
                new OzlukBilgiler
                {
                    KisiID = 23,
                    TCNo = "55555555555",
                    DogumTarihi = new DateTime(1994, 9, 19),
                    TelefonNo = 5551234567
                },
                new OzlukBilgiler
                {
                    KisiID = 24,
                    TCNo = "44444444444",
                    DogumTarihi = new DateTime(1990, 6, 27),
                    TelefonNo = 5551234567
                },
                new OzlukBilgiler
                {
                    KisiID = 25,
                    TCNo = "33333333333",
                    DogumTarihi = new DateTime(1993, 6, 23),
                    TelefonNo = 5551234567
                },
                new OzlukBilgiler
                {
                    KisiID = 26,
                    TCNo = "22222222222",
                    DogumTarihi = new DateTime(1992, 5, 3),
                    TelefonNo = 5551234567
                },
                new OzlukBilgiler
                {
                    KisiID = 27,
                    TCNo = "11111111111",
                    DogumTarihi = new DateTime(1991, 7, 13),
                    TelefonNo = 5551234567
                }
            );
            modelBuilder.Entity<Takim>().HasData(
                new Takim
                {
                    TakimID = 1,
                    TakimAdi = "TeamA"
                },
                new Takim
                {
                    TakimID = 2,
                    TakimAdi = "TeamB"
                },
                new Takim
                {
                    TakimID = 3,
                    TakimAdi = "TeamC"
                }
            );
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kisi>()
                .HasOne(e => e.OzlukBilgiler)
                .WithOne(e => e.Kisi)
                .HasForeignKey<OzlukBilgiler>(e => e.KisiID);

            SeedData(modelBuilder);
        }


    }


}
