using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_02_EFCore.Migrations
{
    /// <inheritdoc />
    public partial class ManyToManyRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseID",
                table: "Stud_Course",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentID",
                table: "Stud_Course",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Course_CourseID",
                table: "Stud_Course",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Course_StudentID",
                table: "Stud_Course",
                column: "StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Course_Course_CourseID",
                table: "Stud_Course",
                column: "CourseID",
                principalTable: "Course",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Course_Students_StudentID",
                table: "Stud_Course",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Course_Course_CourseID",
                table: "Stud_Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Course_Students_StudentID",
                table: "Stud_Course");

            migrationBuilder.DropIndex(
                name: "IX_Stud_Course_CourseID",
                table: "Stud_Course");

            migrationBuilder.DropIndex(
                name: "IX_Stud_Course_StudentID",
                table: "Stud_Course");

            migrationBuilder.DropColumn(
                name: "CourseID",
                table: "Stud_Course");

            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "Stud_Course");
        }
    }
}
