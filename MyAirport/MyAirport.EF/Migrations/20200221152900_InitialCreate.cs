using Microsoft.EntityFrameworkCore.Migrations;

namespace MyAirport.EF.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bagages",
                columns: table => new
                {
                    BagageId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VolId = table.Column<int>(nullable: false),
                    CODE_IATA = table.Column<string>(nullable: true),
                    DATE_CREATION = table.Column<int>(nullable: false),
                    CLASSE = table.Column<string>(nullable: true),
                    PKG = table.Column<string>(nullable: true),
                    IMM = table.Column<string>(nullable: true),
                    PAX = table.Column<int>(nullable: false),
                    DES = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bagages", x => x.BagageId);
                });

            migrationBuilder.CreateTable(
                name: "Vols",
                columns: table => new
                {
                    VolId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CIE = table.Column<int>(nullable: false),
                    LIG = table.Column<string>(nullable: true),
                    JEX = table.Column<int>(nullable: false),
                    DHC = table.Column<string>(nullable: true),
                    PKG = table.Column<string>(nullable: true),
                    IMM = table.Column<string>(nullable: true),
                    PAX = table.Column<int>(nullable: false),
                    DES = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vols", x => x.VolId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bagages");

            migrationBuilder.DropTable(
                name: "Vols");
        }
    }
}
