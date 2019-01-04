using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AuctionWebAPI.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuctionItems",
                columns: table => new
                {
                    ItemNumber = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemDescription = table.Column<string>(nullable: false),
                    RatingPrice = table.Column<long>(nullable: false),
                    BidPrice = table.Column<long>(nullable: false),
                    BidCustomName = table.Column<string>(nullable: true),
                    BidCustomPhone = table.Column<string>(nullable: true),
                    BidTimeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuctionItems", x => x.ItemNumber);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuctionItems");
        }
    }
}
