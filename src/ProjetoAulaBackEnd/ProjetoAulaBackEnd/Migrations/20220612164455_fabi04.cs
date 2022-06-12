using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoAulaBackEnd.Migrations
{
    public partial class fabi04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CheckIn",
                table: "Imovel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CheckOut",
                table: "Imovel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DistanciaPraia",
                table: "Imovel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ValorDiaria",
                table: "Imovel",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CheckIn",
                table: "Imovel");

            migrationBuilder.DropColumn(
                name: "CheckOut",
                table: "Imovel");

            migrationBuilder.DropColumn(
                name: "DistanciaPraia",
                table: "Imovel");

            migrationBuilder.DropColumn(
                name: "ValorDiaria",
                table: "Imovel");
        }
    }
}
