using Microsoft.EntityFrameworkCore.Migrations;

namespace projx.Migrations
{
    public partial class ContaUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Conta_UsuarioIdUsuario",
                table: "Conta");

           migrationBuilder.CreateIndex(
                name: "IX_Conta_UsuarioId",
                table: "Conta",
                column: "IdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Conta_Usuario_UsuarioId",
                table: "Conta",
                column: "IdUsuario",
                principalTable: "Usuario",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Conta_UsuarioId",
                table: "Conta");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Conta");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioIdUsuario",
                table: "Conta",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Conta_UsuarioIdUsuario",
                table: "Conta",
                column: "UsuarioIdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Conta_Usuario_UsuarioIdUsuario",
                table: "Conta",
                column: "UsuarioIdUsuario",
                principalTable: "Usuario",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
