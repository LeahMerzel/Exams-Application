using Exams_Application.Core.Repositories;
using Exams_Application.Data.DB;
using Exams_Application.Interfaces;
using Exams_Application.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Exams_Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Exams API",
                    Version = "v1",
                });

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

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Exams API v1");
            });

            app.UseHttpsRedirection();

            app.UseAuthentication(); // You need to configure authentication
            app.UseAuthorization();

            app.MapControllers();
            app.UseCors();

            app.Run();
        }
    }
}
