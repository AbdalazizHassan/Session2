namespace Session2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Hello from dev");
            app.MapGet("/", () => "Hello from session two");

            app.Run();
        }
    }
}
