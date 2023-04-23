
namespace _40thBackend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddSingleton<LiteDBContext>();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Logging.SetMinimumLevel(LogLevel.Debug);
            var app = builder.Build();
            
            // Configure the HTTP request pipeline.
            app.UsePathBase("/40/");
            app.UseRouting();
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseMiddleware<VisitorCounterMiddleware>();
            
            app.MapControllers();
            
            app.UseStaticFiles();
            app.UseDefaultFiles();
            app.MapFallbackToFile("/index.html");
            app.Run();
        }
    }
}