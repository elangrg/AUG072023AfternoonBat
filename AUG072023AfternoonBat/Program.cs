using AUG072023AfternoonBat.Infra;

namespace AUG072023AfternoonBat
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddSingleton<Models.Employee>();

            builder.Services.AddSingleton<Models.ProductCart>();
            builder.Services.AddRouting(options =>
            {
                options.ConstraintMap.Add("alphanumeric", typeof(AlphaNumericConstraint));
            });
            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();


app.MapControllerRoute(
         name: "DefaultNoAdmin",
         pattern: "{controller}/{action}/{id}",
         defaults: new { controller = "Home", action = "Index", id = "" }
         , constraints: new { controller = new NotEqual("Admin") }

     );

 app.MapControllerRoute(
                    name: "BLogRo",
                    pattern: "Archive/{entryDate}",
                    defaults: new { controller = "Blog", action = "Archive" }
                   , constraints: new { entryDate = @"\d{2}-\d{2}-\d{4}" }

     );
            app.MapControllerRoute(name: "SortRoute",
                pattern: "Sortdemo/{id?}/{*values}",
                defaults: new { controller = "sort", action = "Index" }
                );
            
            //app.MapControllerRoute(
            //    name: "default",
            //    pattern: "{controller=DependencyInjectEg}/{action=Index}/{id?}");

            





            app.Run();
        }
    }
}