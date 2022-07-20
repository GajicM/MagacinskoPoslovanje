using Microsoft.EntityFrameworkCore.Migrations;

namespace MagacinskoPoslovanje.Migrations
{
    public partial class DeleteActionRestrict : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Promet_Firma_FirmaId",
                table: "Promet");

            migrationBuilder.DropForeignKey(
                name: "FK_Promet_StavkaMagacina_StavkaMagacinaId",
                table: "Promet");

            migrationBuilder.DropForeignKey(
                name: "FK_Racun_Firma_FirmaId",
                table: "Racun");

            migrationBuilder.DropForeignKey(
                name: "FK_StavkaMagacina_Magacin_MagacinId",
                table: "StavkaMagacina");

            migrationBuilder.DropForeignKey(
                name: "FK_StavkaMagacina_Proizvod_ProizvodId",
                table: "StavkaMagacina");

            migrationBuilder.DropForeignKey(
                name: "FK_StavkaRacuna_Racun_RacunId",
                table: "StavkaRacuna");

            migrationBuilder.DropForeignKey(
                name: "FK_StavkaRacuna_StavkaMagacina_StavkaMagacinaId",
                table: "StavkaRacuna");

            migrationBuilder.AddForeignKey(
                name: "FK_Promet_Firma_FirmaId",
                table: "Promet",
                column: "FirmaId",
                principalTable: "Firma",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Promet_StavkaMagacina_StavkaMagacinaId",
                table: "Promet",
                column: "StavkaMagacinaId",
                principalTable: "StavkaMagacina",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Racun_Firma_FirmaId",
                table: "Racun",
                column: "FirmaId",
                principalTable: "Firma",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StavkaMagacina_Magacin_MagacinId",
                table: "StavkaMagacina",
                column: "MagacinId",
                principalTable: "Magacin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StavkaMagacina_Proizvod_ProizvodId",
                table: "StavkaMagacina",
                column: "ProizvodId",
                principalTable: "Proizvod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StavkaRacuna_Racun_RacunId",
                table: "StavkaRacuna",
                column: "RacunId",
                principalTable: "Racun",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StavkaRacuna_StavkaMagacina_StavkaMagacinaId",
                table: "StavkaRacuna",
                column: "StavkaMagacinaId",
                principalTable: "StavkaMagacina",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Promet_Firma_FirmaId",
                table: "Promet");

            migrationBuilder.DropForeignKey(
                name: "FK_Promet_StavkaMagacina_StavkaMagacinaId",
                table: "Promet");

            migrationBuilder.DropForeignKey(
                name: "FK_Racun_Firma_FirmaId",
                table: "Racun");

            migrationBuilder.DropForeignKey(
                name: "FK_StavkaMagacina_Magacin_MagacinId",
                table: "StavkaMagacina");

            migrationBuilder.DropForeignKey(
                name: "FK_StavkaMagacina_Proizvod_ProizvodId",
                table: "StavkaMagacina");

            migrationBuilder.DropForeignKey(
                name: "FK_StavkaRacuna_Racun_RacunId",
                table: "StavkaRacuna");

            migrationBuilder.DropForeignKey(
                name: "FK_StavkaRacuna_StavkaMagacina_StavkaMagacinaId",
                table: "StavkaRacuna");

            migrationBuilder.AddForeignKey(
                name: "FK_Promet_Firma_FirmaId",
                table: "Promet",
                column: "FirmaId",
                principalTable: "Firma",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Promet_StavkaMagacina_StavkaMagacinaId",
                table: "Promet",
                column: "StavkaMagacinaId",
                principalTable: "StavkaMagacina",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Racun_Firma_FirmaId",
                table: "Racun",
                column: "FirmaId",
                principalTable: "Firma",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StavkaMagacina_Magacin_MagacinId",
                table: "StavkaMagacina",
                column: "MagacinId",
                principalTable: "Magacin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StavkaMagacina_Proizvod_ProizvodId",
                table: "StavkaMagacina",
                column: "ProizvodId",
                principalTable: "Proizvod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StavkaRacuna_Racun_RacunId",
                table: "StavkaRacuna",
                column: "RacunId",
                principalTable: "Racun",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StavkaRacuna_StavkaMagacina_StavkaMagacinaId",
                table: "StavkaRacuna",
                column: "StavkaMagacinaId",
                principalTable: "StavkaMagacina",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
