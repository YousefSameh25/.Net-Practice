namespace MVC2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddSession(conf =>
            {
                conf.IdleTimeout = TimeSpan.FromMinutes(20); // Add configurations for session
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles(); // Allow to response with files like images etc.

            app.UseRouting();

            app.UseSession(); // Enable session.

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();

            /*
             Middle wares:

            3 Types:
            1) Use -> Process request and move it next.
            2) Run -> Process request and terminate.
            3) Map -> Takes url and execute the action according to url.
             

            // Examples:
             * 
            app.Use(async (httpContext, next) =>
            {
                await httpContext.Response.WriteAsync("Middleware 1");

                await next.Invoke();
            });

            // Example of Run (There is no next), Must be at the end.
            app.Run(async (httpContext) =>
            {
                await httpContext.Response.WriteAsync("Middleware 2");
            });

            // Example of Map
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            */
        }
    }
}