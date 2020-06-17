using Microsoft.EntityFrameworkCore.Migrations;

namespace cle_summer_2020_courses.Migrations
{
    public partial class AddedLocationForAllCourses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CourseLocations",
                columns: new[] { "Id", "Building", "CourseId", "RoomNumber" },
                values: new object[] { 3, "Baker Hall", 3, "2" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Machine Learning");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseLocations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Machine Learing");
        }
    }
}
