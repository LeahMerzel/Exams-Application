using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exams_Application.Migrations
{
    /// <inheritdoc />
    public partial class V4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Questions_QuestionNumber",
                table: "Answer");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Users_StudentId",
                table: "Exams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Answer",
                table: "Answer");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "IsCompleted",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "StudentExamId",
                table: "Exams");

            migrationBuilder.RenameTable(
                name: "Answer",
                newName: "Answers");

            migrationBuilder.RenameIndex(
                name: "IX_Answer_QuestionNumber",
                table: "Answers",
                newName: "IX_Answers_QuestionNumber");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Exams",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Grade",
                table: "Exams",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Answers",
                table: "Answers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Questions_QuestionNumber",
                table: "Answers",
                column: "QuestionNumber",
                principalTable: "Questions",
                principalColumn: "QuestionNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Users_StudentId",
                table: "Exams",
                column: "StudentId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Questions_QuestionNumber",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Users_StudentId",
                table: "Exams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Answers",
                table: "Answers");

            migrationBuilder.RenameTable(
                name: "Answers",
                newName: "Answer");

            migrationBuilder.RenameIndex(
                name: "IX_Answers_QuestionNumber",
                table: "Answer",
                newName: "IX_Answer_QuestionNumber");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Exams",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Grade",
                table: "Exams",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Exams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsCompleted",
                table: "Exams",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StudentExamId",
                table: "Exams",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Answer",
                table: "Answer",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_Questions_QuestionNumber",
                table: "Answer",
                column: "QuestionNumber",
                principalTable: "Questions",
                principalColumn: "QuestionNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Users_StudentId",
                table: "Exams",
                column: "StudentId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
