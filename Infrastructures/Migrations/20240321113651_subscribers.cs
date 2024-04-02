using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructures.Migrations
{
    /// <inheritdoc />
    public partial class subscribers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Subscribers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DailyNewsletter = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    AdvertisingUpdates = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    WeekInReview = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    EventUpdates = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    StartupsWeekly = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Podcasts = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscribers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subscribers");
        }
    }
}
