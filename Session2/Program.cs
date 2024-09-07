namespace Session2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/Home", async context =>
                {
                    await context.Response.WriteAsync("You Are at Home Page");
                });

                endpoints.MapPost("/Product", async context =>
                {
                    await context.Response.WriteAsync("You Are at Product Page");
                });
            });

            app.Run(async HttpContext =>
            {
                await HttpContext.Response.WriteAsync("Your Requested Page Not Found");

            });

            app.Run();
        }
    }
}
