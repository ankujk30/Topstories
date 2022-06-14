using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TopstoriesAPI.Migrations
{
    public partial class TopstoriesToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roots",
                columns: table => new
                {
                    Rootid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(nullable: true),
                    Copyright = table.Column<string>(nullable: true),
                    Section = table.Column<string>(nullable: true),
                    Last_updated = table.Column<DateTime>(nullable: false),
                    Num_results = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roots", x => x.Rootid);
                });

            migrationBuilder.CreateTable(
                name: "Topstories",
                columns: table => new
                {
                    Topstoriesid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Section = table.Column<string>(nullable: true),
                    Subsection = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: false),
                    Abstract = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    Uri = table.Column<string>(nullable: true),
                    Byline = table.Column<string>(nullable: true),
                    Item_type = table.Column<string>(nullable: true),
                    Updated_date = table.Column<DateTime>(nullable: false),
                    Created_date = table.Column<DateTime>(nullable: false),
                    Published_date = table.Column<DateTime>(nullable: false),
                    Material_type_facet = table.Column<string>(nullable: true),
                    Kicker = table.Column<string>(nullable: true),
                    Des_facet = table.Column<string>(nullable: true),
                    Org_facet = table.Column<string>(nullable: true),
                    Per_facet = table.Column<string>(nullable: true),
                    Geo_facet = table.Column<string>(nullable: true),
                    Short_url = table.Column<string>(nullable: true),
                    Rootid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topstories", x => x.Topstoriesid);
                    table.ForeignKey(
                        name: "FK_Topstories_Roots_Rootid",
                        column: x => x.Rootid,
                        principalTable: "Roots",
                        principalColumn: "Rootid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Multimedium",
                columns: table => new
                {
                    Multimediumid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(nullable: true),
                    Format = table.Column<string>(nullable: true),
                    Height = table.Column<int>(nullable: false),
                    Width = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Subtype = table.Column<string>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    Copyright = table.Column<string>(nullable: true),
                    Topstoriesid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Multimedium", x => x.Multimediumid);
                    table.ForeignKey(
                        name: "FK_Multimedium_Topstories_Topstoriesid",
                        column: x => x.Topstoriesid,
                        principalTable: "Topstories",
                        principalColumn: "Topstoriesid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Multimedium_Topstoriesid",
                table: "Multimedium",
                column: "Topstoriesid");

            migrationBuilder.CreateIndex(
                name: "IX_Topstories_Rootid",
                table: "Topstories",
                column: "Rootid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Multimedium");

            migrationBuilder.DropTable(
                name: "Topstories");

            migrationBuilder.DropTable(
                name: "Roots");
        }
    }
}
