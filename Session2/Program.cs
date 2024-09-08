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

                endpoints.MapGet("/Products", async context =>
                {
                    await context.Response.WriteAsync("You Are at Products Page");
                });

                endpoints.MapGet("/Products/{id}", async context =>
                {
                    int id = Convert.ToInt32(context.Request.RouteValues["id"]);
                    await context.Response.WriteAsync($"Your Request Product With Id => {id}");
                });

                endpoints.MapGet("/Books/{id}/{author}", async context =>
                {
                    int id = Convert.ToInt32(context.Request.RouteValues["id"]);
                    string Author = context.Request.RouteValues["Author"].ToString();
                    await context.Response.WriteAsync($"Your Request Book With Id => {id} and Author => {Author}");
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
