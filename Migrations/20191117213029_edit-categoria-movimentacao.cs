using Microsoft.EntityFrameworkCore.Migrations;

namespace projx.Migrations
{
    public partial class editcategoriamovimentacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "FlgAtivo",
                table: "CategoriaMovimentacao",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "DscCategoria",
                table: "CategoriaMovimentacao",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FlgAtivo",
                table: "CategoriaMovimentacao",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "DscCategoria",
                table: "CategoriaMovimentacao",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);
        }
    }
}
