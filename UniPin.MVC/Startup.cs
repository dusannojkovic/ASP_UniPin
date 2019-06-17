using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Commands;
using Application.Commands.Category;
using Application.Commands.Post;
using EFCommand;
using EFCommand.CategoryCommand;
using EFCommand.PostCommand;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UniPin_DataAccess;

namespace UniPin.MVC
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<UniPin_Context>();

            //CategoryCommand

            services.AddTransient<ICreateCategoryCommand, EfCreateCategoryCommand>();
            services.AddTransient<IGetAllCategoryCommand, EfGetAllCategoryCommand>();
            services.AddTransient<IGetOneCategoryCommand, EfGetOneCategoryCommand>();
            services.AddTransient<IUpdateCategoryCommand, EfUpdateCategoryCommand>();
            services.AddTransient<IDeleteCategoryCommand, EfDeleteCategoryCommand>();
            services.AddTransient<IAllCategory, EfAllCategory>();
            //PostCommand

            services.AddTransient<IGetPosts, EfGetPosts>();
            services.AddTransient<IGetOnePostCommand, EfOnePost>();
            services.AddTransient<ICreatePostCommand, EfCreatePostPictureCommand>();
            services.AddTransient<IUpdatePostCommand, EfWebUpdate>();
            services.AddTransient<IDeletePostCommand, EfDeletePostCommand>();
            //UserCommand

            services.AddTransient<IAllUser, EfAllUser>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            

            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
