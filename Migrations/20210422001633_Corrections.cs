using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EFCoreDemo.Migrations
{
    public partial class Corrections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Livro",
                type: "varchar(50)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "Autor",
                table: "Livro",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Titulo",
                table: "Livro",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Autor",
                table: "Livro",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
