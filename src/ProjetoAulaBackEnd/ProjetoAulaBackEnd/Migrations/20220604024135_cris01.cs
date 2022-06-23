using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoAulaBackEnd.Migrations
{
    public partial class cris01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoUsuario",
                table: "Hospede",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoUsuario",
                table: "Hospede");
        }
    }
}
