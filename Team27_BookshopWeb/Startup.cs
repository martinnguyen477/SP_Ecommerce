using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Services;

namespace Team27_BookshopWeb
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddDbContext<MyDbContext>(opt =>
            {
                opt.UseSqlServer(Configuration.GetConnectionString("MyDB"));
            });
            services.AddMvc();
            services.AddSession();
            services.AddAuthentication(options=>{
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie(options => {
                options.LoginPath = "/login-register";
                options.AccessDeniedPath = "/User/AccessDenied";
            }).AddCookie("admin", options => {
                options.LoginPath = "/admin/login";
                options.AccessDeniedPath = "/admin/AccessDenied";
            });
            //Register services
            services.AddTransient<IBooksService, BooksService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IPublishersService, PublishersService>();
            services.AddTransient<IAuthorTranslatorService, AuthorTranslatorService>();
            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IOrdersService, OrdersService>();
            services.AddTransient<IDashboardService, DashboadService>();
            services.AddTransient<ITKDoanhThuService, TKDoanhThuService>();
            services.AddTransient<IPaymentService, PaymentMethodService>();
            services.AddTransient<IThongKeService, ThongKeService>();
            services.AddTransient<ICouponService, CouponService>();
            services.AddTransient<ICommentService, CommentService>();
            services.AddTransient<ICartsService, CartsService>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseSession();
            /*Change static files (js, css...) folder from "wwwroot" folder to "Team27StaticFiles"*/
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(env.ContentRootPath, "Team27StaticFiles")),
                RequestPath = "/Team27StaticFiles"
            });

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //Map area route for admin
                endpoints.MapControllerRoute(
                    name: "admin",
                    pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "login-register",
                    pattern: "login-register",
                    defaults: new { controller = "User", action = "Register" });

                endpoints.MapControllerRoute(
                    name: "admin login",
                    pattern: "admin/login",
                    defaults: new {area="admin", controller = "Employee", action = "Login" });

                endpoints.MapControllerRoute(
                    name: "logout",
                    pattern: "logout",
                    defaults: new { controller = "User", action = "Logout" });

                endpoints.MapControllerRoute(
                    name: "shop",
                    pattern: "cua-hang/{*article}",
                    defaults: new { controller = "Shop", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "shop filter",
                    pattern: "{filterType}/{slugOrId}",
                    defaults: new { controller = "Shop", action = "Filter" });

                endpoints.MapControllerRoute(
                    name: "shop search",
                    pattern: "tim-kiem",
                    defaults: new { controller = "Shop", action = "Search" });

                endpoints.MapControllerRoute(
                    name: "product detail",
                    pattern: "sach/{bookSlug}",
                    defaults: new { controller = "ProductDetails", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
