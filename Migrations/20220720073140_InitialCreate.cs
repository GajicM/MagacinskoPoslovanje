using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MagacinskoPoslovanje.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Firma",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dobavljac = table.Column<bool>(type: "bit", nullable: false),
                    Proizvodjac = table.Column<bool>(type: "bit", nullable: false),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lokacija = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firma", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Magacin",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lokacija = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Magacin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proizvod",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cena = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proizvod", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Racun",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirmaId = table.Column<long>(type: "bigint", nullable: false),
                    TipPrometa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racun", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Racun_Firma_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firma",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StavkaMagacina",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MagacinId = table.Column<long>(type: "bigint", nullable: false),
                    ProizvodId = table.Column<long>(type: "bigint", nullable: false),
                    Kolicina = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StavkaMagacina", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StavkaMagacina_Magacin_MagacinId",
                        column: x => x.MagacinId,
                        principalTable: "Magacin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StavkaMagacina_Proizvod_ProizvodId",
                        column: x => x.ProizvodId,
                        principalTable: "Proizvod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Promet",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmaId = table.Column<long>(type: "bigint", nullable: false),
                    StavkaMagacinaId = table.Column<long>(type: "bigint", nullable: false),
                    Kolicina = table.Column<long>(type: "bigint", nullable: false),
                    TipPrometa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Promet_Firma_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firma",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Promet_StavkaMagacina_StavkaMagacinaId",
                        column: x => x.StavkaMagacinaId,
                        principalTable: "StavkaMagacina",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StavkaRacuna",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kolicina = table.Column<int>(type: "int", nullable: false),
                    StavkaMagacinaId = table.Column<long>(type: "bigint", nullable: false),
                    RacunId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StavkaRacuna", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StavkaRacuna_Racun_RacunId",
                        column: x => x.RacunId,
                        principalTable: "Racun",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StavkaRacuna_StavkaMagacina_StavkaMagacinaId",
                        column: x => x.StavkaMagacinaId,
                        principalTable: "StavkaMagacina",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Promet_FirmaId",
                table: "Promet",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_Promet_StavkaMagacinaId",
                table: "Promet",
                column: "StavkaMagacinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Racun_FirmaId",
                table: "Racun",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkaMagacina_MagacinId",
                table: "StavkaMagacina",
                column: "MagacinId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkaMagacina_ProizvodId",
                table: "StavkaMagacina",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkaRacuna_RacunId",
                table: "StavkaRacuna",
                column: "RacunId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkaRacuna_StavkaMagacinaId",
                table: "StavkaRacuna",
                column: "StavkaMagacinaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Promet");

            migrationBuilder.DropTable(
                name: "StavkaRacuna");

            migrationBuilder.DropTable(
                name: "Racun");

            migrationBuilder.DropTable(
                name: "StavkaMagacina");

            migrationBuilder.DropTable(
                name: "Firma");

            migrationBuilder.DropTable(
                name: "Magacin");

            migrationBuilder.DropTable(
                name: "Proizvod");
        }
    }
}
