using System;
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
            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "StudentsExams");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "StudentsExams");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "StudentsExams");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "StudentsExams");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "StudentsExams");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "StudentsExams");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "StudentsExams");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "StudentsExams");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "StudentsExams");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "StudentsExams");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "StudentsExams");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "StudentsExams");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "StudentsExams");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "StudentsExams");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Answers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Users",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "StudentsExams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "StudentsExams",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "StudentsExams",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "StudentsExams",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "StudentsExams",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "StudentsExams",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "StudentsExams",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "StudentsExams",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "StudentsExams",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "StudentsExams",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "StudentsExams",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "StudentsExams",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "StudentsExams",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "StudentsExams",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Questions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Questions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Questions",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Questions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Questions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Exams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Exams",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Exams",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Exams",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Exams",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Exams",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Exams",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Exams",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Exams",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Exams",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Exams",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Exams",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Exams",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Exams",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Courses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Courses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Courses",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Courses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Courses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Answers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Answers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Answers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Answers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Answers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Answers",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Answers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Answers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Answers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Answers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Answers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Answers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Answers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Answers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
