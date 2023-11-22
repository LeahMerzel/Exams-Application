using Exams_Application.Models;
using Microsoft.EntityFrameworkCore;

namespace Exams_Application.DB
{
    public class ExamsDbContext : DbContext
    {
        public ExamsDbContext(DbContextOptions<ExamsDbContext> options)
        : base(options)
        {
        }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<ExamStudent> StudentsExams { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\\ProjectModels;Initial Catalog=ExamsApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exam>()
                .HasMany(e => e.StudentsToDoExam)
                .WithMany(s => s.ExamsToDo);
            modelBuilder.Entity<Exam>()
                .HasMany(e => e.ExamStudentsTook);
               /* .WithOne(es => es.Exam)
                .HasForeignKey(es => es.ExamId);*/
            modelBuilder.Entity<Exam>()
                .HasMany(e => e.ExamQuestions);
            modelBuilder.Entity<Teacher>()
                .HasMany(t => t.TeachersStudents)
                .WithMany(s => s.StudentsTeachers);
            modelBuilder.Entity<Teacher>()
                .HasMany(t => t.AllTeachersExams);
            modelBuilder.Entity<Student>()
                .HasMany(s => s.StudentsTeachers)
                .WithMany(t => t.TeachersStudents);
            modelBuilder.Entity<Student>()
                .HasMany(s => s.ExamsToDo)
                .WithMany(e => e.StudentsToDoExam);
            modelBuilder.Entity<Student>()
                .HasMany(s => s.AllExamsTaken);
            modelBuilder.Entity<Question>()
                .HasMany(q => q.Answers);
            modelBuilder.Entity<ExamStudent>()
                     .HasKey(es => new { es.ExamId, es.StudentId });

            modelBuilder.Entity<ExamStudent>()
                .HasOne(es => es.Exam)
                .WithMany(e => e.ExamStudentsTook)
                .HasForeignKey(es => es.ExamId);

            modelBuilder.Entity<ExamStudent>()
                .HasOne(es => es.Student)
                .WithMany(s => s.AllExamsTaken)
                .HasForeignKey(es => es.StudentId);

        }
    }
}
