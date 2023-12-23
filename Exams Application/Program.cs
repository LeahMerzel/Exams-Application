using Exams_Application.Core.Repositories;
using Exams_Application.Data.DB;
using Exams_Application.Interfaces;
using Exams_Application.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Exams_Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c => {
                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                c.IgnoreObsoleteActions();
                c.IgnoreObsoleteProperties();
                c.CustomSchemaIds(type => type.FullName);
            });

            builder.Services.AddScoped<AdminRepository>();
            builder.Services.AddScoped<AnswerRepository>();
            builder.Services.AddScoped<CourseRepository>();
            builder.Services.AddScoped<ExamsRepository>();
            builder.Services.AddScoped<QuestionRepository>();
            builder.Services.AddScoped<StudentExamRepository>();
            builder.Services.AddScoped<StudentRepository>();
            builder.Services.AddScoped<TeacherRepository>();
            builder.Services.AddScoped<UserAccountRepository>();
            builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            builder.Services.AddDbContext<ExamsDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("project")));

            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    builder =>
                    {
                        builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
                    });
            });

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthentication();//need to do auth
            app.UseAuthorization();

            app.MapControllers();
            app.UseCors();


            app.Run();
        }
    }
}