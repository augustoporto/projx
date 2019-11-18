using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace projx.Migrations
{
    public partial class Datas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataCriacao",
                table: "Usuario",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCriacao",
                table: "Movimentacao",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataLancamento",
                table: "Movimentacao",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataFinal",
                table: "Agendamento",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataInicio",
                table: "Agendamento",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataCriacao",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "DataCriacao",
                table: "Movimentacao");

            migrationBuilder.DropColumn(
                name: "DataLancamento",
                table: "Movimentacao");

            migrationBuilder.DropColumn(
                name: "DataFinal",
                table: "Agendamento");

            migrationBuilder.DropColumn(
                name: "DataInicio",
                table: "Agendamento");
        }
    }
}
