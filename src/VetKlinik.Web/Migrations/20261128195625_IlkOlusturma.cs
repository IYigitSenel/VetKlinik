using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetKlinik.Web.Migrations
{
    /// <inheritdoc />
    public partial class IlkOlusturma : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Klinikler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ad = table.Column<string>(type: "TEXT", nullable: false),
                    Adres = table.Column<string>(type: "TEXT", nullable: false),
                    Telefon = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klinikler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sahipler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AdSoyad = table.Column<string>(type: "TEXT", nullable: false),
                    Telefon = table.Column<string>(type: "TEXT", nullable: false),
                    Eposta = table.Column<string>(type: "TEXT", nullable: false),
                    KullaniciId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sahipler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hizmetler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ad = table.Column<string>(type: "TEXT", nullable: false),
                    SureDakika = table.Column<int>(type: "INTEGER", nullable: false),
                    Fiyat = table.Column<decimal>(type: "TEXT", precision: 10, scale: 2, nullable: false),
                    KlinikId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hizmetler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hizmetler_Klinikler_KlinikId",
                        column: x => x.KlinikId,
                        principalTable: "Klinikler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Veterinerler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AdSoyad = table.Column<string>(type: "TEXT", nullable: false),
                    Uzmanlik = table.Column<string>(type: "TEXT", nullable: false),
                    KullaniciId = table.Column<string>(type: "TEXT", nullable: true),
                    KlinikId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veterinerler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Veterinerler_Klinikler_KlinikId",
                        column: x => x.KlinikId,
                        principalTable: "Klinikler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hayvanlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ad = table.Column<string>(type: "TEXT", nullable: false),
                    Tur = table.Column<string>(type: "TEXT", nullable: false),
                    Irk = table.Column<string>(type: "TEXT", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Kilo = table.Column<double>(type: "REAL", nullable: false),
                    SahipId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hayvanlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hayvanlar_Sahipler_SahipId",
                        column: x => x.SahipId,
                        principalTable: "Sahipler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MusaitlikSaatleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Gun = table.Column<int>(type: "INTEGER", nullable: false),
                    Baslangic = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    Bitis = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    VeterinerId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusaitlikSaatleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MusaitlikSaatleri_Veterinerler_VeterinerId",
                        column: x => x.VeterinerId,
                        principalTable: "Veterinerler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Asilar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ad = table.Column<string>(type: "TEXT", nullable: false),
                    UygulamaTarihi = table.Column<DateTime>(type: "TEXT", nullable: false),
                    SonrakiTarih = table.Column<DateTime>(type: "TEXT", nullable: true),
                    HayvanId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asilar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asilar_Hayvanlar_HayvanId",
                        column: x => x.HayvanId,
                        principalTable: "Hayvanlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Randevular",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Baslangic = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Bitis = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Durum = table.Column<int>(type: "INTEGER", nullable: false),
                    HayvanId = table.Column<int>(type: "INTEGER", nullable: false),
                    VeterinerId = table.Column<int>(type: "INTEGER", nullable: false),
                    HizmetId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Randevular", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Randevular_Hayvanlar_HayvanId",
                        column: x => x.HayvanId,
                        principalTable: "Hayvanlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Randevular_Hizmetler_HizmetId",
                        column: x => x.HizmetId,
                        principalTable: "Hizmetler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Randevular_Veterinerler_VeterinerId",
                        column: x => x.VeterinerId,
                        principalTable: "Veterinerler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MuayeneNotlari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Not = table.Column<string>(type: "TEXT", nullable: false),
                    Tarih = table.Column<DateTime>(type: "TEXT", nullable: false),
                    RandevuId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MuayeneNotlari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MuayeneNotlari_Randevular_RandevuId",
                        column: x => x.RandevuId,
                        principalTable: "Randevular",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asilar_HayvanId",
                table: "Asilar",
                column: "HayvanId");

            migrationBuilder.CreateIndex(
                name: "IX_Hayvanlar_SahipId",
                table: "Hayvanlar",
                column: "SahipId");

            migrationBuilder.CreateIndex(
                name: "IX_Hizmetler_KlinikId",
                table: "Hizmetler",
                column: "KlinikId");

            migrationBuilder.CreateIndex(
                name: "IX_MuayeneNotlari_RandevuId",
                table: "MuayeneNotlari",
                column: "RandevuId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MusaitlikSaatleri_VeterinerId",
                table: "MusaitlikSaatleri",
                column: "VeterinerId");

            migrationBuilder.CreateIndex(
                name: "IX_Randevular_HayvanId",
                table: "Randevular",
                column: "HayvanId");

            migrationBuilder.CreateIndex(
                name: "IX_Randevular_HizmetId",
                table: "Randevular",
                column: "HizmetId");

            migrationBuilder.CreateIndex(
                name: "IX_Randevular_VeterinerId",
                table: "Randevular",
                column: "VeterinerId");

            migrationBuilder.CreateIndex(
                name: "IX_Veterinerler_KlinikId",
                table: "Veterinerler",
                column: "KlinikId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asilar");

            migrationBuilder.DropTable(
                name: "MuayeneNotlari");

            migrationBuilder.DropTable(
                name: "MusaitlikSaatleri");

            migrationBuilder.DropTable(
                name: "Randevular");

            migrationBuilder.DropTable(
                name: "Hayvanlar");

            migrationBuilder.DropTable(
                name: "Hizmetler");

            migrationBuilder.DropTable(
                name: "Veterinerler");

            migrationBuilder.DropTable(
                name: "Sahipler");

            migrationBuilder.DropTable(
                name: "Klinikler");
        }
    }
}
