using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoAulaBackEnd.Migrations
{
    public partial class fabi03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Academia",
                table: "Imovel",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ArCondicionado",
                table: "Imovel",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "Imovel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Churrasqueira",
                table: "Imovel",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Cozinha",
                table: "Imovel",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "DesativarImovel",
                table: "Imovel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DispImovel",
                table: "Imovel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "DuchaExterna",
                table: "Imovel",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Elevador",
                table: "Imovel",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Estacionamento",
                table: "Imovel",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Foto2",
                table: "Imovel",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Foto3",
                table: "Imovel",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Foto4",
                table: "Imovel",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Jogos",
                table: "Imovel",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Lareira",
                table: "Imovel",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "MaquinaLavar",
                table: "Imovel",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PET",
                table: "Imovel",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Patio",
                table: "Imovel",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Piscina",
                table: "Imovel",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "QtdeBanheiros",
                table: "Imovel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QtdeCamas",
                table: "Imovel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QtdeQuartos",
                table: "Imovel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Rampa",
                table: "Imovel",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Sauna",
                table: "Imovel",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Suite",
                table: "Imovel",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "VistaMar",
                table: "Imovel",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "WiFi",
                table: "Imovel",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Academia",
                table: "Imovel");

            migrationBuilder.DropColumn(
                name: "ArCondicionado",
                table: "Imovel");

            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "Imovel");

            migrationBuilder.DropColumn(
                name: "Churrasqueira",
                table: "Imovel");

            migrationBuilder.DropColumn(
                name: "Cozinha",
                table: "Imovel");

            migrationBuilder.DropColumn(
                name: "DesativarImovel",
                table: "Imovel");

            migrationBuilder.DropColumn(
                name: "DispImovel",
                table: "Imovel");

            migrationBuilder.DropColumn(
                name: "DuchaExterna",
                table: "Imovel");

            migrationBuilder.DropColumn(
                name: "Elevador",
                table: "Imovel");

            migrationBuilder.DropColumn(
                name: "Estacionamento",
                table: "Imovel");

            migrationBuilder.DropColumn(
                name: "Foto2",
                table: "Imovel");

            migrationBuilder.DropColumn(
                name: "Foto3",
                table: "Imovel");

            migrationBuilder.DropColumn(
                name: "Foto4",
                table: "Imovel");

            migrationBuilder.DropColumn(
                name: "Jogos",
                table: "Imovel");

            migrationBuilder.DropColumn(
                name: "Lareira",
                table: "Imovel");

            migrationBuilder.DropColumn(
                name: "MaquinaLavar",
                table: "Imovel");

            migrationBuilder.DropColumn(
                name: "PET",
                table: "Imovel");

            migrationBuilder.DropColumn(
                name: "Patio",
                table: "Imovel");

            migrationBuilder.DropColumn(
                name: "Piscina",
                table: "Imovel");

            migrationBuilder.DropColumn(
                name: "QtdeBanheiros",
                table: "Imovel");

            migrationBuilder.DropColumn(
                name: "QtdeCamas",
                table: "Imovel");

            migrationBuilder.DropColumn(
                name: "QtdeQuartos",
                table: "Imovel");

            migrationBuilder.DropColumn(
                name: "Rampa",
                table: "Imovel");

            migrationBuilder.DropColumn(
                name: "Sauna",
                table: "Imovel");

            migrationBuilder.DropColumn(
                name: "Suite",
                table: "Imovel");

            migrationBuilder.DropColumn(
                name: "VistaMar",
                table: "Imovel");

            migrationBuilder.DropColumn(
                name: "WiFi",
                table: "Imovel");
        }
    }
}
