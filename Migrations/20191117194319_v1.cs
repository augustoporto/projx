using Microsoft.EntityFrameworkCore.Migrations;

namespace projx.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NomUsuario",
                table: "Usuario",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DscCategoria",
                table: "CategoriaMovimentacao",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.RenameColumn(
                name: "CategoriaIdCategoria",
                table: "Movimentacao",
                newName: "IdCategoria");

            migrationBuilder.RenameColumn(
                name: "ContaIdConta",
                table: "Movimentacao",
                newName: "IdConta");

            migrationBuilder.RenameColumn(
                name: "UsuarioIdUsuario",
                table: "Movimentacao",
                newName: "IdUsuario");

            migrationBuilder.RenameColumn(
                name: "UsuarioIdUsuario",
                table: "Conta",
                newName: "IdUsuario");

            migrationBuilder.RenameColumn(
                name: "MovimentacaoIdMovimentacao",
                table: "Agendamento",
                newName: "MovimentacaoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NomUsuario",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "DscCategoria",
                table: "CategoriaMovimentacao",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
