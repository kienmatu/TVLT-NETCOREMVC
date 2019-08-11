using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsApp.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PostTitle = table.Column<string>(maxLength: 200, nullable: true),
                    PostContent = table.Column<string>(type: "ntext", nullable: true),
                    PostTeaser = table.Column<string>(maxLength: 400, nullable: true),
                    ViewCount = table.Column<int>(nullable: false, defaultValue: 0),
                    CateID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Posts_Categories_CateID",
                        column: x => x.CateID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryName" },
                values: new object[] { 1, "Thể thao" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "ID", "CateID", "PostContent", "PostTeaser", "PostTitle" },
                values: new object[] { 1, 1, "abc xyz", null, "Quang Hải lập công abc xyz" });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CateID",
                table: "Posts",
                column: "CateID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
