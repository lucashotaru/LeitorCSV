using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeitorCBF.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rodadas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeTimeCasa = table.Column<string>(nullable: false),
                    PlacarTimeCasa = table.Column<int>(nullable: false),
                    NomeTimeVisitante = table.Column<string>(nullable: false),
                    PlacarTimeVisitante = table.Column<int>(nullable: false),
                    Rodada = table.Column<int>(nullable: false),
                    DataHoraJogo = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rodadas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rodadas");
        }
    }
}
