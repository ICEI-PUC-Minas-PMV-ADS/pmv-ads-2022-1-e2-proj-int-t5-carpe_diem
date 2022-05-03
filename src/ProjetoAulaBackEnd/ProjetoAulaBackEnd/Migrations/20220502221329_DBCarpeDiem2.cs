using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoAulaBackEnd.Migrations
{
    public partial class DBCarpeDiem2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Hospede",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Senha",
                table: "Hospede");
        }
    }
}
