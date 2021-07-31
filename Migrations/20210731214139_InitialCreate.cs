using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace symphony.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StatusExame",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Chave = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    BloqueioExame = table.Column<bool>(type: "bit", nullable: false),
                    MotivoBloqueio = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusExame", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatusLote",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Chave = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusLote", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lote",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroLote = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    StatusLote = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: true),
                    CodigoLC = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    LaboratorioConveniado = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CNPJ = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false),
                    NomeUsuario = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CargoUsuario = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SoftwareHouse = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    LIS = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoEnvio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataInsercao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PrevisaoRetorno = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TermoDeAceite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextoErro = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lote", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lote_StatusLote_StatusId",
                        column: x => x.StatusId,
                        principalTable: "StatusLote",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LoteExame",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdLote = table.Column<int>(type: "int", nullable: false),
                    LoteId = table.Column<int>(type: "int", nullable: true),
                    DescMatLab = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CodExmLab = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DescExmLab = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    StatusExame = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoteExame", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoteExame_Lote_LoteId",
                        column: x => x.LoteId,
                        principalTable: "Lote",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LoteExame_StatusExame_StatusId",
                        column: x => x.StatusId,
                        principalTable: "StatusExame",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lote_StatusId",
                table: "Lote",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_LoteExame_LoteId",
                table: "LoteExame",
                column: "LoteId");

            migrationBuilder.CreateIndex(
                name: "IX_LoteExame_StatusId",
                table: "LoteExame",
                column: "StatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoteExame");

            migrationBuilder.DropTable(
                name: "Lote");

            migrationBuilder.DropTable(
                name: "StatusExame");

            migrationBuilder.DropTable(
                name: "StatusLote");
        }
    }
}
