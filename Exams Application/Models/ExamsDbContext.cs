﻿using Microsoft.EntityFrameworkCore;

namespace Exams_Application.Models
{
    public class ExamsDbContext: DbContext
    {
        public ExamsDbContext(DbContextOptions<ExamsDbContext> options)
         : base(options)
        {
        }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<ExamStudent> ExamsStudents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\\ProjectModels;Initial Catalog=ExamsApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExamStudent>()
                        .HasKey(es => new { es.ExamId, es.StudentId });

            modelBuilder.Entity<ExamStudent>()
                .HasOne(es => es.Exam)
                .WithMany(e => e.StudentsToDoExam)
                .HasForeignKey(es => es.ExamId);

            modelBuilder.Entity<ExamStudent>()
                .HasOne(es => es.Student)
                .WithMany(s => s.ExamsToDo)
                .HasForeignKey(es => es.StudentId);
        }
    



    }
}
