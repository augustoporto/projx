using Microsoft.EntityFrameworkCore.Migrations;

namespace projx.Migrations
{
    public partial class altermovimentacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DscDetalhada",
                table: "Movimentacao",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DscMovimentacao",
                table: "Movimentacao",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DscDetalhada",
                table: "Movimentacao");

            migrationBuilder.DropColumn(
                name: "DscMovimentacao",
                table: "Movimentacao");
        }
    }
}
