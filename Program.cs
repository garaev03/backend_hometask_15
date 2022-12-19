namespace hometask_15
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddRazorPages();

            var app = builder.Build();

            app.UseRouting();

            app.MapControllerRoute(name: "default",pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}