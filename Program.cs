
using DotNetEnv;
using LostnFound.Data;
using LostnFound.Repositories;
using LostnFound.Services;
using Microsoft.EntityFrameworkCore;

namespace LostnFound;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        // Database
        Env.Load();
        var ServerModuleConection = $"server={Environment.GetEnvironmentVariable("HOST")};" +
                                   $"port={Environment.GetEnvironmentVariable("PORT")};" +
                                   $"database={Environment.GetEnvironmentVariable("DATABASE")};" +
                                   $"uid={Environment.GetEnvironmentVariable("USER")};" +
                                   $"password={Environment.GetEnvironmentVariable("PASSWORD")}";
        builder.Services.AddDbContext<ClassDbContext>(options => options.UseNpgsql(ServerModuleConection));

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();


        //services scope
        builder.Services.AddScoped<IcategoryRepositorY, CategoryServices>();
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

        app.Run();
    }
}
