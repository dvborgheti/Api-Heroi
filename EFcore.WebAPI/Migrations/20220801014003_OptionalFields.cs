using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFcore.WebAPI.Migrations
{
    public partial class OptionalFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Armas_Herois_HeroiId",
                table: "Armas");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Batalhas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Armas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "HeroiId",
                table: "Armas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Armas_Herois_HeroiId",
                table: "Armas",
                column: "HeroiId",
                principalTable: "Herois",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Armas_Herois_HeroiId",
                table: "Armas");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Batalhas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Armas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HeroiId",
                table: "Armas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Armas_Herois_HeroiId",
                table: "Armas",
                column: "HeroiId",
                principalTable: "Herois",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
