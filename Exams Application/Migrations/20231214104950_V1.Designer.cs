﻿// <auto-generated />
using System;
using Exams_Application.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Exams_Application.Migrations
{
    [DbContext(typeof(ExamsDbContext))]
    [Migration("20231214104950_V1")]
    partial class V1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CourseStudent", b =>
                {
                    b.Property<Guid>("CourseStudentsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StudentsCoursesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CourseStudentsId", "StudentsCoursesId");

                    b.HasIndex("StudentsCoursesId");

                    b.ToTable("CourseStudent");
                });

            modelBuilder.Entity("CourseTeacher", b =>
                {
                    b.Property<Guid>("CourseTeachersId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TeachersCoursesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CourseTeachersId", "TeachersCoursesId");

                    b.HasIndex("TeachersCoursesId");

                    b.ToTable("CourseTeacher");
                });

            modelBuilder.Entity("Exams_Application.Models.Admin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNum")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Exams_Application.Models.Answer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AnswerDetailed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AnswerNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("QuestionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("Exams_Application.Models.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Exams_Application.Models.Exam", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExamDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExamDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExamGrade")
                        .HasColumnType("int");

                    b.Property<float>("ExamGradeAvg")
                        .HasColumnType("real");

                    b.Property<bool>("IsOrderQuestionsRandom")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("TeacherId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("WasExamLoggedInToByStudent")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("Exams_Application.Models.Question", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CorrectAnswerIndex")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("ExamId")
                        .HasColumnType("int");

                    b.Property<Guid?>("ExamId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsImage")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOrderAnswersRandom")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuestionDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionNumber")
                        .HasColumnType("int");

                    b.Property<int>("QuestionScoring")
                        .HasColumnType("int");

                    b.Property<Guid?>("StudentExamId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ExamId1");

                    b.HasIndex("StudentExamId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Exams_Application.Models.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EnrolementDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("GradeAvg")
                        .HasColumnType("real");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNum")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Exams_Application.Models.StudentExam", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("ExamId")
                        .HasColumnType("int");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<Guid?>("StudentId1")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StudentId1");

                    b.ToTable("StudentsExams");
                });

            modelBuilder.Entity("Exams_Application.Models.Teacher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNum")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("CourseStudent", b =>
                {
                    b.HasOne("Exams_Application.Models.Student", null)
                        .WithMany()
                        .HasForeignKey("CourseStudentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Exams_Application.Models.Course", null)
                        .WithMany()
                        .HasForeignKey("StudentsCoursesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CourseTeacher", b =>
                {
                    b.HasOne("Exams_Application.Models.Teacher", null)
                        .WithMany()
                        .HasForeignKey("CourseTeachersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Exams_Application.Models.Course", null)
                        .WithMany()
                        .HasForeignKey("TeachersCoursesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Exams_Application.Models.Answer", b =>
                {
                    b.HasOne("Exams_Application.Models.Question", null)
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Exams_Application.Models.Exam", b =>
                {
                    b.HasOne("Exams_Application.Models.Course", null)
                        .WithMany("CourseExams")
                        .HasForeignKey("CourseId");

                    b.HasOne("Exams_Application.Models.Teacher", null)
                        .WithMany("AllTeachersExams")
                        .HasForeignKey("TeacherId");
                });

            modelBuilder.Entity("Exams_Application.Models.Question", b =>
                {
                    b.HasOne("Exams_Application.Models.Exam", null)
                        .WithMany("ExamQuestions")
                        .HasForeignKey("ExamId1");

                    b.HasOne("Exams_Application.Models.StudentExam", null)
                        .WithMany("MistakesInExam")
                        .HasForeignKey("StudentExamId");
                });

            modelBuilder.Entity("Exams_Application.Models.StudentExam", b =>
                {
                    b.HasOne("Exams_Application.Models.Student", null)
                        .WithMany("StudentsTakenExams")
                        .HasForeignKey("StudentId1");
                });

            modelBuilder.Entity("Exams_Application.Models.Course", b =>
                {
                    b.Navigation("CourseExams");
                });

            modelBuilder.Entity("Exams_Application.Models.Exam", b =>
                {
                    b.Navigation("ExamQuestions");
                });

            modelBuilder.Entity("Exams_Application.Models.Question", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("Exams_Application.Models.Student", b =>
                {
                    b.Navigation("StudentsTakenExams");
                });

            modelBuilder.Entity("Exams_Application.Models.StudentExam", b =>
                {
                    b.Navigation("MistakesInExam");
                });

            modelBuilder.Entity("Exams_Application.Models.Teacher", b =>
                {
                    b.Navigation("AllTeachersExams");
                });
#pragma warning restore 612, 618
        }
    }
}
