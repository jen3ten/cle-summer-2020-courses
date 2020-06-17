using Microsoft.EntityFrameworkCore.Migrations;

namespace cle_summer_2020_courses.Migrations
{
    public partial class AddedCourseLocationModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseLocations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Building = table.Column<string>(nullable: true),
                    RoomNumber = table.Column<string>(nullable: true),
                    CourseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseLocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseLocations_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CourseLocations",
                columns: new[] { "Id", "Building", "CourseId", "RoomNumber" },
                values: new object[] { 1, "Schmidt Hall", 1, "102B" });

            migrationBuilder.InsertData(
                table: "CourseLocations",
                columns: new[] { "Id", "Building", "CourseId", "RoomNumber" },
                values: new object[] { 2, "Harrison", 2, "335" });

            migrationBuilder.CreateIndex(
                name: "IX_CourseLocations_CourseId",
                table: "CourseLocations",
                column: "CourseId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseLocations");
        }
    }
}
