using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamManagment.UI.Migrations
{
    public partial class Sedd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Takim",
                columns: new[] { "TakimID", "TakimAdi" },
                values: new object[,]
                {
                    { 1, "TeamA" },
                    { 2, "TeamB" },
                    { 3, "TeamC" }
                });

            migrationBuilder.InsertData(
                table: "Unvan",
                columns: new[] { "UnvanID", "UnvanAdi" },
                values: new object[,]
                {
                    { 1, "Takım Lideri" },
                    { 2, "Analist" },
                    { 3, "Developer" },
                    { 4, "Tester" }
                });

            migrationBuilder.InsertData(
                table: "Kisi",
                columns: new[] { "KisiID", "Ad", "Soyad", "UnvanID" },
                values: new object[,]
                {
                    { 1, "Ali", "Erdal", 1 },
                    { 10, "Sena", "İnci", 4 },
                    { 27, "Özlem", "Dal", 3 },
                    { 26, "Tekin", "Durmaz", 3 },
                    { 25, "Furkan", "Aslan", 3 },
                    { 24, "Sibel", "Türk", 3 },
                    { 23, "Osman", "Yürek", 3 },
                    { 22, "Hatice", "Pek", 3 },
                    { 21, "Mazhar", "Pak", 3 },
                    { 20, "Kenan", "Soy", 3 },
                    { 19, "Bahtiyar", "Uzun", 3 },
                    { 18, "Nermin", "Yıldız", 3 },
                    { 11, "Bahadır", "Tepe", 4 },
                    { 17, "Aysun", "Toka", 3 },
                    { 15, "Neşe", "Yılamz", 3 },
                    { 14, "Orhan", "Pak", 3 },
                    { 13, "Mustafa", "Hal", 3 },
                    { 9, "Ali", "Uzun", 2 },
                    { 8, "Berk", "Tar", 2 },
                    { 7, "Berke", "Atar", 2 },
                    { 6, "Leyla", "Tepe", 2 },
                    { 5, "Fatma", "Tek", 2 },
                    { 4, "Esra", "Ay", 2 },
                    { 3, "Doruk", "Yurt", 1 },
                    { 2, "Mehmet", "Bilge", 1 },
                    { 16, "Hakan", "Dur", 3 },
                    { 12, "Yasemin", "Tepe", 4 }
                });

            migrationBuilder.InsertData(
                table: "OzlukBilgiler",
                columns: new[] { "KisiID", "DogumTarihi", "TCNo", "TelefonNo" },
                values: new object[,]
                {
                    { 1, new DateTime(1991, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "12345678901", 5551234567L },
                    { 10, new DateTime(1994, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "98765432109", 5551234567L },
                    { 27, new DateTime(1991, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "11111111111", 5551234567L },
                    { 26, new DateTime(1992, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "22222222222", 5551234567L },
                    { 25, new DateTime(1993, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "33333333333", 5551234567L },
                    { 24, new DateTime(1990, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "44444444444", 5551234567L },
                    { 23, new DateTime(1994, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "55555555555", 5551234567L },
                    { 22, new DateTime(1989, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "66666666666", 5551234567L },
                    { 21, new DateTime(1995, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "77777777777", 5551234567L },
                    { 20, new DateTime(1993, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "88888888888", 5551234567L },
                    { 19, new DateTime(1982, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "99999999999", 5551234567L },
                    { 18, new DateTime(1984, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "10987654321", 5551234567L },
                    { 11, new DateTime(1996, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "87654321098", 5551234567L },
                    { 17, new DateTime(1996, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "21098765432", 5551234567L },
                    { 15, new DateTime(1990, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "43210987654", 5551234567L },
                    { 14, new DateTime(1990, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "54321098765", 5551234567L },
                    { 13, new DateTime(1994, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "65432109876", 5551234567L },
                    { 9, new DateTime(1991, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "90123456789", 5551234567L },
                    { 8, new DateTime(1991, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "89012345678", 5551234567L },
                    { 7, new DateTime(1993, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "78901234567", 5551234567L },
                    { 6, new DateTime(1997, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "67890123456", 5551234567L },
                    { 5, new DateTime(1987, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "56789012345", 5551234567L },
                    { 4, new DateTime(1992, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "45678901234", 5551234567L },
                    { 3, new DateTime(1987, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "34567890123", 5551234567L },
                    { 2, new DateTime(1992, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "23456789012", 5551234567L },
                    { 16, new DateTime(1990, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "32109876543", 5551234567L },
                    { 12, new DateTime(1985, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "76543210987", 5551234567L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OzlukBilgiler",
                keyColumn: "KisiID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OzlukBilgiler",
                keyColumn: "KisiID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OzlukBilgiler",
                keyColumn: "KisiID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OzlukBilgiler",
                keyColumn: "KisiID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OzlukBilgiler",
                keyColumn: "KisiID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OzlukBilgiler",
                keyColumn: "KisiID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OzlukBilgiler",
                keyColumn: "KisiID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OzlukBilgiler",
                keyColumn: "KisiID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OzlukBilgiler",
                keyColumn: "KisiID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OzlukBilgiler",
                keyColumn: "KisiID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OzlukBilgiler",
                keyColumn: "KisiID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "OzlukBilgiler",
                keyColumn: "KisiID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "OzlukBilgiler",
                keyColumn: "KisiID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "OzlukBilgiler",
                keyColumn: "KisiID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "OzlukBilgiler",
                keyColumn: "KisiID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "OzlukBilgiler",
                keyColumn: "KisiID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "OzlukBilgiler",
                keyColumn: "KisiID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "OzlukBilgiler",
                keyColumn: "KisiID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "OzlukBilgiler",
                keyColumn: "KisiID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "OzlukBilgiler",
                keyColumn: "KisiID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "OzlukBilgiler",
                keyColumn: "KisiID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "OzlukBilgiler",
                keyColumn: "KisiID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "OzlukBilgiler",
                keyColumn: "KisiID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "OzlukBilgiler",
                keyColumn: "KisiID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "OzlukBilgiler",
                keyColumn: "KisiID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "OzlukBilgiler",
                keyColumn: "KisiID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "OzlukBilgiler",
                keyColumn: "KisiID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Takim",
                keyColumn: "TakimID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Takim",
                keyColumn: "TakimID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Takim",
                keyColumn: "TakimID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Kisi",
                keyColumn: "KisiID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Kisi",
                keyColumn: "KisiID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Kisi",
                keyColumn: "KisiID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Kisi",
                keyColumn: "KisiID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Kisi",
                keyColumn: "KisiID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Kisi",
                keyColumn: "KisiID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Kisi",
                keyColumn: "KisiID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Kisi",
                keyColumn: "KisiID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Kisi",
                keyColumn: "KisiID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Kisi",
                keyColumn: "KisiID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Kisi",
                keyColumn: "KisiID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Kisi",
                keyColumn: "KisiID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Kisi",
                keyColumn: "KisiID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Kisi",
                keyColumn: "KisiID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Kisi",
                keyColumn: "KisiID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Kisi",
                keyColumn: "KisiID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Kisi",
                keyColumn: "KisiID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Kisi",
                keyColumn: "KisiID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Kisi",
                keyColumn: "KisiID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Kisi",
                keyColumn: "KisiID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Kisi",
                keyColumn: "KisiID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Kisi",
                keyColumn: "KisiID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Kisi",
                keyColumn: "KisiID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Kisi",
                keyColumn: "KisiID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Kisi",
                keyColumn: "KisiID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Kisi",
                keyColumn: "KisiID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Kisi",
                keyColumn: "KisiID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Unvan",
                keyColumn: "UnvanID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Unvan",
                keyColumn: "UnvanID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Unvan",
                keyColumn: "UnvanID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Unvan",
                keyColumn: "UnvanID",
                keyValue: 4);
        }
    }
}
