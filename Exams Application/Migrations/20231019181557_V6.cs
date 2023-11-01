using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exams_Application.Migrations
{
    /// <inheritdoc />
    public partial class V6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Exams_ExamNumber",
                table: "Questions");

            migrationBuilder.RenameColumn(
                name: "ExamNumber",
                table: "Questions",
                newName: "ExamId");

            migrationBuilder.RenameIndex(
                name: "IX_Questions_ExamNumber",
                table: "Questions",
                newName: "IX_Questions_ExamId");

            migrationBuilder.RenameColumn(
                name: "ExamNumber",
                table: "Exams",
                newName: "ExamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Exams_ExamId",
                table: "Questions",
                column: "ExamId",
                principalTable: "Exams",
                principalColumn: "ExamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Exams_ExamId",
                table: "Questions");

            migrationBuilder.RenameColumn(
                name: "ExamId",
                table: "Questions",
                newName: "ExamNumber");

            migrationBuilder.RenameIndex(
                name: "IX_Questions_ExamId",
                table: "Questions",
                newName: "IX_Questions_ExamNumber");

            migrationBuilder.RenameColumn(
                name: "ExamId",
                table: "Exams",
                newName: "ExamNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Exams_ExamNumber",
                table: "Questions",
                column: "ExamNumber",
                principalTable: "Exams",
                principalColumn: "ExamNumber");
        }
    }
}
