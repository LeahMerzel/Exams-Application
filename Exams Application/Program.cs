using Exams_Application.Repositories;

namespace Exams_Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c => {
                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                c.IgnoreObsoleteActions();
                c.IgnoreObsoleteProperties();
                c.CustomSchemaIds(type => type.FullName);
            });
            //do i need to do thid to use multiple controllers?:
            //builder.Services.AddControllers();

            //is singleton appropriate here? 
            builder.Services.AddSingleton<IAccountCrudRepo, AccountCrudRepo>();
            builder.Services.AddSingleton<IAdminCrudRepo, AdminCrudRepo>();
            builder.Services.AddSingleton<IStudentCrudRepo, StudentCrudRepo>();
            builder.Services.AddSingleton<ITeacherCrudRepo, TeacherCrudRepo>();

            //what does this do?
            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    builder =>
                    {
                        builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
                    });
            });


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();
            app.UseCors();


            app.Run();
        }
    }
}