
namespace CurrentTime
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

          

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();            

            app.UseHttpsRedirection();
            app.MapGet("time/utc", () =>  Results.Ok(DateTime.UtcNow) );
            

            

            app.Run();
        }
    }
}
