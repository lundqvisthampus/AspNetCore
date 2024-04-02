using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructures.Migrations
{
    /// <inheritdoc />
    public partial class Courses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscountPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseHours = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LikesNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LikesProcent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsBestSeller = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsDigital = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    AuthorYtSubs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorFbFollowers = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
