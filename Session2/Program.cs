namespace Session2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            var app = builder.Build();

            app.UseRouting();

            app.MapControllerRoute(
                name: "default",
                pattern: "/{Controller=Home}/{Action=Index}",
                defaults: new { Controller = "Home", Action = "Index" }
                );

            #region Demo Practise
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/Home", async context =>
            //    {
            //        await context.Response.WriteAsync("You Are at Home Page");
            //    });

            //    endpoints.MapGet("/Products/{id:int?}", async context =>
            //    {
            //        var idData = context.Request.RouteValues["id"];

            //        if (idData != null)
            //        {
            //            int id = Convert.ToInt32(idData);
            //            await context.Response.WriteAsync($"Your Request Product With Id => {id}");
            //        }

            //        else
            //            await context.Response.WriteAsync("You Are at Products Page");

            //    });

            //    endpoints.MapGet("/Books/{id:int}/{author:alpha}", async context =>
            //    {
            //        int id = Convert.ToInt32(context.Request.RouteValues["id"]);
            //        string author = context.Request.RouteValues["author"].ToString();
            //        await context.Response.WriteAsync($"Your Request Book With Id => {id} and Author => {author}");
            //    });

            //});


            //app.Run(async HttpContext =>
            //{
            //    await HttpContext.Response.WriteAsync("Your Requested Page Not Found");

            //});
            #endregion


            app.Run();
        }
    }
}
