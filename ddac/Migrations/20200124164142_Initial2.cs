using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ddac.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activity",
                columns: table => new
                {
                    Actid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActName = table.Column<string>(nullable: true),
                    ActPrice = table.Column<decimal>(nullable: false),
                    AQty = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activity", x => x.Actid);
                });

            migrationBuilder.CreateTable(
                name: "BeautynSpa",
                columns: table => new
                {
                    Bid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BeautyName = table.Column<string>(nullable: true),
                    BeautyPrice = table.Column<decimal>(nullable: false),
                    BQty = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeautynSpa", x => x.Bid);
                });

            migrationBuilder.CreateTable(
                name: "Restaurant",
                columns: table => new
                {
                    Rid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RestName = table.Column<string>(nullable: true),
                    RestPrice = table.Column<decimal>(nullable: false),
                    RDateCheckInDate = table.Column<DateTime>(nullable: false),
                    RDateCheckOutDate = table.Column<DateTime>(nullable: false),
                    RQty = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurant", x => x.Rid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activity");

            migrationBuilder.DropTable(
                name: "BeautynSpa");

            migrationBuilder.DropTable(
                name: "Restaurant");
        }
    }
}
