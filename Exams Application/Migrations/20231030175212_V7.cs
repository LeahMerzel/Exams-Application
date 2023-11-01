using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exams_Application.Migrations
{
    /// <inheritdoc />
    public partial class V7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Questions_QuestionNumber",
                table: "Answers");

            migrationBuilder.DropIndex(
                name: "IX_Answers_QuestionNumber",
                table: "Answers");

            migrationBuilder.AddColumn<bool>(
                name: "IsImage",
                table: "Questions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsOrderAnswersRandom",
                table: "Questions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExamBegganAt",
                table: "Exams",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ExamDateTime",
                table: "Exams",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ExamDuration",
                table: "Exams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsOrderQuestionsRandom",
                table: "Exams",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "QuestionNumber",
                table: "Answers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AnswerDetailed",
                table: "Answers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCorrect",
                table: "Answers",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Questions_QuestionId",
                table: "Answers");

            migrationBuilder.DropIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "IsImage",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "IsOrderAnswersRandom",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "ExamBegganAt",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "ExamDateTime",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "ExamDuration",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "IsOrderQuestionsRandom",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "AnswerDetailed",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "IsCorrect",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "QuestionId",
                table: "Answers");

            migrationBuilder.AlterColumn<int>(
                name: "QuestionNumber",
                table: "Answers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionNumber",
                table: "Answers",
                column: "QuestionNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Questions_QuestionNumber",
                table: "Answers",
                column: "QuestionNumber",
                principalTable: "Questions",
                principalColumn: "QuestionNumber");
        }
    }
}
