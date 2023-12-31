﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TeamManagment.UI.Models.Core.Context;

namespace TeamManagment.UI.Migrations
{
    [DbContext(typeof(MyDBContext))]
    [Migration("20230904191122_Sedd")]
    partial class Sedd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TeamManagment.UI.Models.Core.Entites.Kisi", b =>
                {
                    b.Property<int>("KisiID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Soyad")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("UnvanID")
                        .HasColumnType("int");

                    b.HasKey("KisiID");

                    b.HasIndex("UnvanID");

                    b.ToTable("Kisi");

                    b.HasData(
                        new
                        {
                            KisiID = 1,
                            Ad = "Ali",
                            Soyad = "Erdal",
                            UnvanID = 1
                        },
                        new
                        {
                            KisiID = 2,
                            Ad = "Mehmet",
                            Soyad = "Bilge",
                            UnvanID = 1
                        },
                        new
                        {
                            KisiID = 3,
                            Ad = "Doruk",
                            Soyad = "Yurt",
                            UnvanID = 1
                        },
                        new
                        {
                            KisiID = 4,
                            Ad = "Esra",
                            Soyad = "Ay",
                            UnvanID = 2
                        },
                        new
                        {
                            KisiID = 5,
                            Ad = "Fatma",
                            Soyad = "Tek",
                            UnvanID = 2
                        },
                        new
                        {
                            KisiID = 6,
                            Ad = "Leyla",
                            Soyad = "Tepe",
                            UnvanID = 2
                        },
                        new
                        {
                            KisiID = 7,
                            Ad = "Berke",
                            Soyad = "Atar",
                            UnvanID = 2
                        },
                        new
                        {
                            KisiID = 8,
                            Ad = "Berk",
                            Soyad = "Tar",
                            UnvanID = 2
                        },
                        new
                        {
                            KisiID = 9,
                            Ad = "Ali",
                            Soyad = "Uzun",
                            UnvanID = 2
                        },
                        new
                        {
                            KisiID = 10,
                            Ad = "Sena",
                            Soyad = "İnci",
                            UnvanID = 4
                        },
                        new
                        {
                            KisiID = 11,
                            Ad = "Bahadır",
                            Soyad = "Tepe",
                            UnvanID = 4
                        },
                        new
                        {
                            KisiID = 12,
                            Ad = "Yasemin",
                            Soyad = "Tepe",
                            UnvanID = 4
                        },
                        new
                        {
                            KisiID = 13,
                            Ad = "Mustafa",
                            Soyad = "Hal",
                            UnvanID = 3
                        },
                        new
                        {
                            KisiID = 14,
                            Ad = "Orhan",
                            Soyad = "Pak",
                            UnvanID = 3
                        },
                        new
                        {
                            KisiID = 15,
                            Ad = "Neşe",
                            Soyad = "Yılamz",
                            UnvanID = 3
                        },
                        new
                        {
                            KisiID = 16,
                            Ad = "Hakan",
                            Soyad = "Dur",
                            UnvanID = 3
                        },
                        new
                        {
                            KisiID = 17,
                            Ad = "Aysun",
                            Soyad = "Toka",
                            UnvanID = 3
                        },
                        new
                        {
                            KisiID = 18,
                            Ad = "Nermin",
                            Soyad = "Yıldız",
                            UnvanID = 3
                        },
                        new
                        {
                            KisiID = 19,
                            Ad = "Bahtiyar",
                            Soyad = "Uzun",
                            UnvanID = 3
                        },
                        new
                        {
                            KisiID = 20,
                            Ad = "Kenan",
                            Soyad = "Soy",
                            UnvanID = 3
                        },
                        new
                        {
                            KisiID = 21,
                            Ad = "Mazhar",
                            Soyad = "Pak",
                            UnvanID = 3
                        },
                        new
                        {
                            KisiID = 22,
                            Ad = "Hatice",
                            Soyad = "Pek",
                            UnvanID = 3
                        },
                        new
                        {
                            KisiID = 23,
                            Ad = "Osman",
                            Soyad = "Yürek",
                            UnvanID = 3
                        },
                        new
                        {
                            KisiID = 24,
                            Ad = "Sibel",
                            Soyad = "Türk",
                            UnvanID = 3
                        },
                        new
                        {
                            KisiID = 25,
                            Ad = "Furkan",
                            Soyad = "Aslan",
                            UnvanID = 3
                        },
                        new
                        {
                            KisiID = 26,
                            Ad = "Tekin",
                            Soyad = "Durmaz",
                            UnvanID = 3
                        },
                        new
                        {
                            KisiID = 27,
                            Ad = "Özlem",
                            Soyad = "Dal",
                            UnvanID = 3
                        });
                });

            modelBuilder.Entity("TeamManagment.UI.Models.Core.Entites.OzlukBilgiler", b =>
                {
                    b.Property<int>("KisiID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("TCNo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<long?>("TelefonNo")
                        .HasColumnType("bigint");

                    b.HasKey("KisiID");

                    b.ToTable("OzlukBilgiler");

                    b.HasData(
                        new
                        {
                            KisiID = 1,
                            DogumTarihi = new DateTime(1991, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TCNo = "12345678901",
                            TelefonNo = 5551234567L
                        },
                        new
                        {
                            KisiID = 2,
                            DogumTarihi = new DateTime(1992, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TCNo = "23456789012",
                            TelefonNo = 5551234567L
                        },
                        new
                        {
                            KisiID = 3,
                            DogumTarihi = new DateTime(1987, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TCNo = "34567890123",
                            TelefonNo = 5551234567L
                        },
                        new
                        {
                            KisiID = 4,
                            DogumTarihi = new DateTime(1992, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TCNo = "45678901234",
                            TelefonNo = 5551234567L
                        },
                        new
                        {
                            KisiID = 5,
                            DogumTarihi = new DateTime(1987, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TCNo = "56789012345",
                            TelefonNo = 5551234567L
                        },
                        new
                        {
                            KisiID = 6,
                            DogumTarihi = new DateTime(1997, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TCNo = "67890123456",
                            TelefonNo = 5551234567L
                        },
                        new
                        {
                            KisiID = 7,
                            DogumTarihi = new DateTime(1993, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TCNo = "78901234567",
                            TelefonNo = 5551234567L
                        },
                        new
                        {
                            KisiID = 8,
                            DogumTarihi = new DateTime(1991, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TCNo = "89012345678",
                            TelefonNo = 5551234567L
                        },
                        new
                        {
                            KisiID = 9,
                            DogumTarihi = new DateTime(1991, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TCNo = "90123456789",
                            TelefonNo = 5551234567L
                        },
                        new
                        {
                            KisiID = 10,
                            DogumTarihi = new DateTime(1994, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TCNo = "98765432109",
                            TelefonNo = 5551234567L
                        },
                        new
                        {
                            KisiID = 11,
                            DogumTarihi = new DateTime(1996, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TCNo = "87654321098",
                            TelefonNo = 5551234567L
                        },
                        new
                        {
                            KisiID = 12,
                            DogumTarihi = new DateTime(1985, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TCNo = "76543210987",
                            TelefonNo = 5551234567L
                        },
                        new
                        {
                            KisiID = 13,
                            DogumTarihi = new DateTime(1994, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TCNo = "65432109876",
                            TelefonNo = 5551234567L
                        },
                        new
                        {
                            KisiID = 14,
                            DogumTarihi = new DateTime(1990, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TCNo = "54321098765",
                            TelefonNo = 5551234567L
                        },
                        new
                        {
                            KisiID = 15,
                            DogumTarihi = new DateTime(1990, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TCNo = "43210987654",
                            TelefonNo = 5551234567L
                        },
                        new
                        {
                            KisiID = 16,
                            DogumTarihi = new DateTime(1990, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TCNo = "32109876543",
                            TelefonNo = 5551234567L
                        },
                        new
                        {
                            KisiID = 17,
                            DogumTarihi = new DateTime(1996, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TCNo = "21098765432",
                            TelefonNo = 5551234567L
                        },
                        new
                        {
                            KisiID = 18,
                            DogumTarihi = new DateTime(1984, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TCNo = "10987654321",
                            TelefonNo = 5551234567L
                        },
                        new
                        {
                            KisiID = 19,
                            DogumTarihi = new DateTime(1982, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TCNo = "99999999999",
                            TelefonNo = 5551234567L
                        },
                        new
                        {
                            KisiID = 20,
                            DogumTarihi = new DateTime(1993, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TCNo = "88888888888",
                            TelefonNo = 5551234567L
                        },
                        new
                        {
                            KisiID = 21,
                            DogumTarihi = new DateTime(1995, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TCNo = "77777777777",
                            TelefonNo = 5551234567L
                        },
                        new
                        {
                            KisiID = 22,
                            DogumTarihi = new DateTime(1989, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TCNo = "66666666666",
                            TelefonNo = 5551234567L
                        },
                        new
                        {
                            KisiID = 23,
                            DogumTarihi = new DateTime(1994, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TCNo = "55555555555",
                            TelefonNo = 5551234567L
                        },
                        new
                        {
                            KisiID = 24,
                            DogumTarihi = new DateTime(1990, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TCNo = "44444444444",
                            TelefonNo = 5551234567L
                        },
                        new
                        {
                            KisiID = 25,
                            DogumTarihi = new DateTime(1993, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TCNo = "33333333333",
                            TelefonNo = 5551234567L
                        },
                        new
                        {
                            KisiID = 26,
                            DogumTarihi = new DateTime(1992, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TCNo = "22222222222",
                            TelefonNo = 5551234567L
                        },
                        new
                        {
                            KisiID = 27,
                            DogumTarihi = new DateTime(1991, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TCNo = "11111111111",
                            TelefonNo = 5551234567L
                        });
                });

            modelBuilder.Entity("TeamManagment.UI.Models.Core.Entites.Takim", b =>
                {
                    b.Property<int>("TakimID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TakimAdi")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TakimID");

                    b.ToTable("Takim");

                    b.HasData(
                        new
                        {
                            TakimID = 1,
                            TakimAdi = "TeamA"
                        },
                        new
                        {
                            TakimID = 2,
                            TakimAdi = "TeamB"
                        },
                        new
                        {
                            TakimID = 3,
                            TakimAdi = "TeamC"
                        });
                });

            modelBuilder.Entity("TeamManagment.UI.Models.Core.Entites.TakimKisi", b =>
                {
                    b.Property<int>("TakimKisiID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("KisiID")
                        .HasColumnType("int");

                    b.Property<int?>("TakimID")
                        .HasColumnType("int");

                    b.HasKey("TakimKisiID");

                    b.HasIndex("KisiID");

                    b.HasIndex("TakimID");

                    b.ToTable("TakimKisi");
                });

            modelBuilder.Entity("TeamManagment.UI.Models.Core.Entites.Unvan", b =>
                {
                    b.Property<int>("UnvanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UnvanAdi")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UnvanID");

                    b.ToTable("Unvan");

                    b.HasData(
                        new
                        {
                            UnvanID = 1,
                            UnvanAdi = "Takım Lideri"
                        },
                        new
                        {
                            UnvanID = 2,
                            UnvanAdi = "Analist"
                        },
                        new
                        {
                            UnvanID = 3,
                            UnvanAdi = "Developer"
                        },
                        new
                        {
                            UnvanID = 4,
                            UnvanAdi = "Tester"
                        });
                });

            modelBuilder.Entity("TeamManagment.UI.Models.Core.Entites.Kisi", b =>
                {
                    b.HasOne("TeamManagment.UI.Models.Core.Entites.Unvan", "Unvan")
                        .WithMany("Kisi")
                        .HasForeignKey("UnvanID");

                    b.Navigation("Unvan");
                });

            modelBuilder.Entity("TeamManagment.UI.Models.Core.Entites.OzlukBilgiler", b =>
                {
                    b.HasOne("TeamManagment.UI.Models.Core.Entites.Kisi", "Kisi")
                        .WithOne("OzlukBilgiler")
                        .HasForeignKey("TeamManagment.UI.Models.Core.Entites.OzlukBilgiler", "KisiID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kisi");
                });

            modelBuilder.Entity("TeamManagment.UI.Models.Core.Entites.TakimKisi", b =>
                {
                    b.HasOne("TeamManagment.UI.Models.Core.Entites.Kisi", "Kisi")
                        .WithMany("TakimKisi")
                        .HasForeignKey("KisiID");

                    b.HasOne("TeamManagment.UI.Models.Core.Entites.Takim", "Takim")
                        .WithMany("TakimKisi")
                        .HasForeignKey("TakimID");

                    b.Navigation("Kisi");

                    b.Navigation("Takim");
                });

            modelBuilder.Entity("TeamManagment.UI.Models.Core.Entites.Kisi", b =>
                {
                    b.Navigation("OzlukBilgiler");

                    b.Navigation("TakimKisi");
                });

            modelBuilder.Entity("TeamManagment.UI.Models.Core.Entites.Takim", b =>
                {
                    b.Navigation("TakimKisi");
                });

            modelBuilder.Entity("TeamManagment.UI.Models.Core.Entites.Unvan", b =>
                {
                    b.Navigation("Kisi");
                });
#pragma warning restore 612, 618
        }
    }
}
