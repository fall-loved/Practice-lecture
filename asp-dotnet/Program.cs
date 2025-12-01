using MyWebApplication.Abstraction;
using MyWebApplication.Middlewares;
using MyWebApplication.Services;

namespace MyWebApplication;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        builder.Services.AddScoped<IRequestCounter, RequestCounterService>();
        builder.Services.AddSwaggerGen();
        
        var app = builder.Build();
        
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        
        app.UseMiddleware<ResponseTimeMiddleware>();

        app.MapControllers();

        app.Run();
    }
}