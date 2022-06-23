using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoAulaBackEnd.Migrations
{
    public partial class edu2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Imovel",
                columns: table => new
                {
                    IdImovel = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HospedeId = table.Column<int>(type: "int", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoEsp = table.Column<int>(type: "int", nullable: false),
                    TipoAc = table.Column<int>(type: "int", nullable: false),
                    QtdeHospedes = table.Column<int>(type: "int", nullable: false),
                    QtdeCamas = table.Column<int>(type: "int", nullable: false),
                    QtdeQuartos = table.Column<int>(type: "int", nullable: false),
                    QtdeBanheiros = table.Column<int>(type: "int", nullable: false),
                    Foto1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Foto2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Foto3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Foto4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Academia = table.Column<bool>(type: "bit", nullable: false),
                    PET = table.Column<bool>(type: "bit", nullable: false),
                    ArCondicionado = table.Column<bool>(type: "bit", nullable: false),
                    Churrasqueira = table.Column<bool>(type: "bit", nullable: false),
                    Cozinha = table.Column<bool>(type: "bit", nullable: false),
                    DuchaExterna = table.Column<bool>(type: "bit", nullable: false),
                    Elevador = table.Column<bool>(type: "bit", nullable: false),
                    Estacionamento = table.Column<bool>(type: "bit", nullable: false),
                    Jogos = table.Column<bool>(type: "bit", nullable: false),
                    Lareira = table.Column<bool>(type: "bit", nullable: false),
                    MaquinaLavar = table.Column<bool>(type: "bit", nullable: false),
                    Patio = table.Column<bool>(type: "bit", nullable: false),
                    Piscina = table.Column<bool>(type: "bit", nullable: false),
                    Rampa = table.Column<bool>(type: "bit", nullable: false),
                    Sauna = table.Column<bool>(type: "bit", nullable: false),
                    Suite = table.Column<bool>(type: "bit", nullable: false),
                    VistaMar = table.Column<bool>(type: "bit", nullable: false),
                    WiFi = table.Column<bool>(type: "bit", nullable: false),
                    CheckIn = table.Column<int>(type: "int", nullable: false),
                    CheckOut = table.Column<int>(type: "int", nullable: false),
                    DistanciaPraia = table.Column<int>(type: "int", nullable: false),
                    ValorDiaria = table.Column<int>(type: "int", nullable: false),
                    DispImovel = table.Column<int>(type: "int", nullable: false),
                    DesativarImovel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imovel", x => x.IdImovel);
                    table.ForeignKey(
                        name: "FK_Imovel_Hospede_HospedeId",
                        column: x => x.HospedeId,
                        principalTable: "Hospede",
                        principalColumn: "IdHospede",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Imovel_HospedeId",
                table: "Imovel",
                column: "HospedeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Imovel");
        }
    }
}
