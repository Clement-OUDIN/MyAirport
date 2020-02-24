using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyAirport.EF.Migrations
{
    public partial class _6thCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CODE_IATA",
                table: "Bagages");

            migrationBuilder.DropColumn(
                name: "DATE_CREATION",
                table: "Bagages");

            migrationBuilder.DropColumn(
                name: "DES",
                table: "Bagages");

            migrationBuilder.DropColumn(
                name: "IMM",
                table: "Bagages");

            migrationBuilder.DropColumn(
                name: "PAX",
                table: "Bagages");

            migrationBuilder.DropColumn(
                name: "PKG",
                table: "Bagages");

            migrationBuilder.AlterColumn<string>(
                name: "PKG",
                table: "Vols",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "PAX",
                table: "Vols",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "LIG",
                table: "Vols",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "JEX",
                table: "Vols",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "IMM",
                table: "Vols",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DHC",
                table: "Vols",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DES",
                table: "Vols",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CIE",
                table: "Vols",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "VolId",
                table: "Vols",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "VolId",
                table: "Bagages",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "CLASSE",
                table: "Bagages",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BagageId",
                table: "Bagages",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "CODEIATA",
                table: "Bagages",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DATECREATION",
                table: "Bagages",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Destination",
                table: "Bagages",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Escale",
                table: "Bagages",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SSUR",
                table: "Bagages",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CODEIATA",
                table: "Bagages");

            migrationBuilder.DropColumn(
                name: "DATECREATION",
                table: "Bagages");

            migrationBuilder.DropColumn(
                name: "Destination",
                table: "Bagages");

            migrationBuilder.DropColumn(
                name: "Escale",
                table: "Bagages");

            migrationBuilder.DropColumn(
                name: "SSUR",
                table: "Bagages");

            migrationBuilder.AlterColumn<string>(
                name: "PKG",
                table: "Vols",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PAX",
                table: "Vols",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(short));

            migrationBuilder.AlterColumn<string>(
                name: "LIG",
                table: "Vols",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "JEX",
                table: "Vols",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(short));

            migrationBuilder.AlterColumn<string>(
                name: "IMM",
                table: "Vols",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DHC",
                table: "Vols",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "DES",
                table: "Vols",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CIE",
                table: "Vols",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "VolId",
                table: "Vols",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "VolId",
                table: "Bagages",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "CLASSE",
                table: "Bagages",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "BagageId",
                table: "Bagages",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "CODE_IATA",
                table: "Bagages",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DATE_CREATION",
                table: "Bagages",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DES",
                table: "Bagages",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IMM",
                table: "Bagages",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PAX",
                table: "Bagages",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PKG",
                table: "Bagages",
                type: "TEXT",
                nullable: true);
        }
    }
}
