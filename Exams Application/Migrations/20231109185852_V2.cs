using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exams_Application.Migrations
{
    /// <inheritdoc />
    public partial class V2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Questions_QuestionId",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Users_StudentId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Exams_ExamId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "StudentsTeacherId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Grade",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "QuestionId",
                table: "Answers");

            migrationBuilder.AlterColumn<int>(
                name: "ExamId",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Exams",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "StudentId1",
                table: "Exams",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuestionNumber1",
                table: "Answers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Exams_StudentId1",
                table: "Exams",
                column: "StudentId1");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionNumber1",
                table: "Answers",
                column: "QuestionNumber1");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Questions_QuestionNumber1",
                table: "Answers",
                column: "QuestionNumber1",
                principalTable: "Questions",
                principalColumn: "QuestionNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Users_StudentId",
                table: "Exams",
                column: "StudentId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Users_StudentId1",
                table: "Exams",
                column: "StudentId1",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Exams_ExamId",
                table: "Questions",
                column: "ExamId",
                principalTable: "Exams",
                principalColumn: "ExamId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Questions_QuestionNumber1",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Users_StudentId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Users_StudentId1",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Exams_ExamId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Exams_StudentId1",
                table: "Exams");

            migrationBuilder.DropIndex(
                name: "IX_Answers_QuestionNumber1",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "StudentId1",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "QuestionNumber1",
                table: "Answers");

            migrationBuilder.AddColumn<int>(
                name: "StudentsTeacherId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ExamId",
                table: "Questions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Exams",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Grade",
                table: "Exams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QuestionId",
                table: "Answers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Questions_QuestionId",
                table: "Answers",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "QuestionNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Users_StudentId",
                table: "Exams",
                column: "StudentId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Exams_ExamId",
                table: "Questions",
                column: "ExamId",
                principalTable: "Exams",
                principalColumn: "ExamId");
        }
    }
}
