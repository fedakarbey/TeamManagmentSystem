using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamManagment.UI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Takim",
                columns: table => new
                {
                    TakimID = table.Column<int>(type: "int", nullable: true)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TakimAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Takim", x => x.TakimID);
                });

            migrationBuilder.CreateTable(
                name: "Unvan",
                columns: table => new
                {
                    UnvanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnvanAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unvan", x => x.UnvanID);
                });

            migrationBuilder.CreateTable(
                name: "Kisi",
                columns: table => new
                {
                    KisiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UnvanID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kisi", x => x.KisiID);
                    table.ForeignKey(
                        name: "FK_Kisi_Unvan_UnvanID",
                        column: x => x.UnvanID,
                        principalTable: "Unvan",
                        principalColumn: "UnvanID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OzlukBilgiler",
                columns: table => new
                {
                    KisiID = table.Column<int>(type: "int", nullable: false),
                    TCNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TelefonNo = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OzlukBilgiler", x => x.KisiID);
                    table.ForeignKey(
                        name: "FK_OzlukBilgiler_Kisi_KisiID",
                        column: x => x.KisiID,
                        principalTable: "Kisi",
                        principalColumn: "KisiID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TakimKisi",
                columns: table => new
                {
                    TakimKisiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TakimID = table.Column<int>(type: "int", nullable: true),
                    KisiID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TakimKisi", x => x.TakimKisiID);
                    table.ForeignKey(
                        name: "FK_TakimKisi_Kisi_KisiID",
                        column: x => x.KisiID,
                        principalTable: "Kisi",
                        principalColumn: "KisiID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TakimKisi_Takim_TakimID",
                        column: x => x.TakimID,
                        principalTable: "Takim",
                        principalColumn: "TakimID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kisi_UnvanID",
                table: "Kisi",
                column: "UnvanID");

            migrationBuilder.CreateIndex(
                name: "IX_TakimKisi_KisiID",
                table: "TakimKisi",
                column: "KisiID");

            migrationBuilder.CreateIndex(
                name: "IX_TakimKisi_TakimID",
                table: "TakimKisi",
                column: "TakimID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OzlukBilgiler");

            migrationBuilder.DropTable(
                name: "TakimKisi");

            migrationBuilder.DropTable(
                name: "Kisi");

            migrationBuilder.DropTable(
                name: "Takim");

            migrationBuilder.DropTable(
                name: "Unvan");
        }
    }
}
