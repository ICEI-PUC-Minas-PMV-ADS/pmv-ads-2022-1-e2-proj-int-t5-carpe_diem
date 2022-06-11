using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoAulaBackEnd.Migrations
{
    public partial class Eduardo1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Imovel",
                columns: table => new
                {
                    IdImovel = table.Column<int>(type: "int", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoEsp = table.Column<int>(type: "int", nullable: false),
                    TipoAc = table.Column<int>(type: "int", nullable: false),
                    QtdeHospedes = table.Column<int>(type: "int", nullable: false),
                    Foto1 = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imovel", x => x.IdImovel);
                    table.ForeignKey(
                        name: "FK_Imovel_Hospede_IdImovel",
                        column: x => x.IdImovel,
                        principalTable: "Hospede",
                        principalColumn: "IdHospede",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Imovel");
        }
    }
}
