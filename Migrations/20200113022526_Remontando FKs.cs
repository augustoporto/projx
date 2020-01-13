using Microsoft.EntityFrameworkCore.Migrations;

namespace projx.Migrations
{
    public partial class RemontandoFKs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendamento_Movimentacao_MovimentacaoIdMovimentacao",
                table: "Agendamento");

            migrationBuilder.DropForeignKey(
                name: "FK_Conta_Usuario_UsuarioId",
                table: "Conta");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimentacao_CategoriaMovimentacao_CategoriaIdCategoria",
                table: "Movimentacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimentacao_Conta_ContaIdConta",
                table: "Movimentacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimentacao_Usuario_UsuarioIdUsuario",
                table: "Movimentacao");

            migrationBuilder.DropIndex(
                name: "IX_Movimentacao_CategoriaIdCategoria",
                table: "Movimentacao");

            migrationBuilder.DropIndex(
                name: "IX_Movimentacao_ContaIdConta",
                table: "Movimentacao");

            migrationBuilder.DropIndex(
                name: "IX_Movimentacao_UsuarioIdUsuario",
                table: "Movimentacao");

            migrationBuilder.DropIndex(
                name: "IX_Conta_UsuarioId",
                table: "Conta");

            migrationBuilder.DropIndex(
                name: "IX_Agendamento_MovimentacaoIdMovimentacao",
                table: "Agendamento");

            migrationBuilder.AddColumn<int>(
                name: "IdCategoriaMovimentacao",
                table: "Movimentacao",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdMovimentacao",
                table: "Agendamento",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movimentacao_IdCategoriaMovimentacao",
                table: "Movimentacao",
                column: "IdCategoriaMovimentacao");

            migrationBuilder.CreateIndex(
                name: "IX_Movimentacao_IdConta",
                table: "Movimentacao",
                column: "IdConta");

            migrationBuilder.CreateIndex(
                name: "IX_Movimentacao_IdUsuario",
                table: "Movimentacao",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Conta_IdUsuario",
                table: "Conta",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamento_IdMovimentacao",
                table: "Agendamento",
                column: "IdMovimentacao");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamento_Movimentacao_IdMovimentacao",
                table: "Agendamento",
                column: "IdMovimentacao",
                principalTable: "Movimentacao",
                principalColumn: "IdMovimentacao",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Conta_Usuario_IdUsuario",
                table: "Conta",
                column: "IdUsuario",
                principalTable: "Usuario",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Movimentacao_CategoriaMovimentacao_IdCategoriaMovimentacao",
                table: "Movimentacao",
                column: "IdCategoriaMovimentacao",
                principalTable: "CategoriaMovimentacao",
                principalColumn: "IdCategoria",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Movimentacao_Conta_IdConta",
                table: "Movimentacao",
                column: "IdConta",
                principalTable: "Conta",
                principalColumn: "IdConta",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Movimentacao_Usuario_IdUsuario",
                table: "Movimentacao",
                column: "IdUsuario",
                principalTable: "Usuario",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendamento_Movimentacao_IdMovimentacao",
                table: "Agendamento");

            migrationBuilder.DropForeignKey(
                name: "FK_Conta_Usuario_IdUsuario",
                table: "Conta");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimentacao_CategoriaMovimentacao_IdCategoriaMovimentacao",
                table: "Movimentacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimentacao_Conta_IdConta",
                table: "Movimentacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimentacao_Usuario_IdUsuario",
                table: "Movimentacao");

            migrationBuilder.DropIndex(
                name: "IX_Movimentacao_IdCategoriaMovimentacao",
                table: "Movimentacao");

            migrationBuilder.DropIndex(
                name: "IX_Movimentacao_IdConta",
                table: "Movimentacao");

            migrationBuilder.DropIndex(
                name: "IX_Movimentacao_IdUsuario",
                table: "Movimentacao");

            migrationBuilder.DropIndex(
                name: "IX_Conta_IdUsuario",
                table: "Conta");

            migrationBuilder.DropIndex(
                name: "IX_Agendamento_IdMovimentacao",
                table: "Agendamento");

            migrationBuilder.DropColumn(
                name: "IdCategoriaMovimentacao",
                table: "Movimentacao");

            migrationBuilder.DropColumn(
                name: "IdConta",
                table: "Movimentacao");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "Movimentacao");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "Conta");

            migrationBuilder.DropColumn(
                name: "IdMovimentacao",
                table: "Agendamento");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaIdCategoria",
                table: "Movimentacao",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContaIdConta",
                table: "Movimentacao",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioIdUsuario",
                table: "Movimentacao",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Conta",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MovimentacaoIdMovimentacao",
                table: "Agendamento",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movimentacao_CategoriaIdCategoria",
                table: "Movimentacao",
                column: "CategoriaIdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Movimentacao_ContaIdConta",
                table: "Movimentacao",
                column: "ContaIdConta");

            migrationBuilder.CreateIndex(
                name: "IX_Movimentacao_UsuarioIdUsuario",
                table: "Movimentacao",
                column: "UsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Conta_UsuarioId",
                table: "Conta",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamento_MovimentacaoIdMovimentacao",
                table: "Agendamento",
                column: "MovimentacaoIdMovimentacao");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamento_Movimentacao_MovimentacaoIdMovimentacao",
                table: "Agendamento",
                column: "MovimentacaoIdMovimentacao",
                principalTable: "Movimentacao",
                principalColumn: "IdMovimentacao",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Conta_Usuario_UsuarioId",
                table: "Conta",
                column: "IdUsuario",
                principalTable: "Usuario",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Movimentacao_CategoriaMovimentacao_CategoriaIdCategoria",
                table: "Movimentacao",
                column: "CategoriaIdCategoria",
                principalTable: "CategoriaMovimentacao",
                principalColumn: "IdCategoria",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Movimentacao_Conta_ContaIdConta",
                table: "Movimentacao",
                column: "ContaIdConta",
                principalTable: "Conta",
                principalColumn: "IdConta",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Movimentacao_Usuario_UsuarioIdUsuario",
                table: "Movimentacao",
                column: "UsuarioIdUsuario",
                principalTable: "Usuario",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
