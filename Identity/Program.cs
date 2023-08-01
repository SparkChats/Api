using DataAccess;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.FileProviders;
using System.Reflection;

namespace Identity
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
            IServiceCollection services = builder.Services;

            services.AddDatabases(builder.Configuration);
            services.AddControllers();
            services.AddMvc(options =>
            {
                options.EnableEndpointRouting = false;
            });

            services.AddMediatR(options =>
            {
                options.RegisterServicesFromAssembly(Assembly
                    .GetExecutingAssembly());
            });

            services.AddIdentity<IdentityUser, IdentityRole>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 8;
            })
                .AddEntityFrameworkStores<AuthorizationDbContext>()
                .AddDefaultTokenProviders();

            services.AddIdentityServer4WithConfiguration()
                .AddDeveloperSigningCredential();

            services.ConfigureApplicationCookie(config =>
            {
                config.Cookie.Name = "Discord.Identity.Cookie";
                config.LoginPath = "/Authentication/Login";
                config.LogoutPath = "/Authentication/Logout";
            });

            WebApplication app = builder.Build();

            app.MapControllers();
            app.UseMvc();
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(app.Environment.ContentRootPath, "wwwroot")),
                RequestPath = "/wwwroot"
            });

            app.UseIdentityServer();

            app.Run();
        }
    }
}