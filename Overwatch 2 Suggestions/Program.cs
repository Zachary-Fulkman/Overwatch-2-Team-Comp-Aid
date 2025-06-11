namespace Overwatch_2_Suggestions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            
            //Add distributed memory cache
            builder.Services.AddDistributedMemoryCache();

            // Add session and configure options
            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);  // session timeout
                options.Cookie.HttpOnly = true;                   // enhance security
                options.Cookie.IsEssential = true;                // make session cookie essential
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseSession();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=TeamBuilder}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
