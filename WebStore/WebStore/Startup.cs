using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebStore.Data;
using WebStore.Data.Interfaces;
using WebStore.Data.Mocks;
using Microsoft.EntityFrameworkCore;
using WebStore.Data.Repository;
using Microsoft.AspNetCore.Http;
using WebStore.Data.Model;

namespace WebStore
{
    public class Startup
    {
        private IConfigurationRoot _confString;

        public Startup(Microsoft.AspNetCore.Hosting.IHostingEnvironment hostEnv)
        {
            _confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbSettings.json").Build();
        }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));
            services.AddRazorPages();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(w => WebStoreCart.GetCart(w));
            services.AddMvc();
            services.AddTransient<IAllCars, CarRepository>();
            services.AddTransient<IAllOrders, OrdersRepository>();
            services.AddTransient<ICarsCategory, CategoryRepository>();
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();
            //app.UseMvcWithDefaultRoute();
            app.UseMvc(routes=> {
                routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(name: "categoryFilter", template: "{Car}/{action}/{category?}", defaults:new { contreller="Car", action="List"});
            });

            using (var scope = app.ApplicationServices.CreateScope())
            {
                ApplicationDbContext context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                DbObjects.Initial(context);
            }

        }
    }
}
