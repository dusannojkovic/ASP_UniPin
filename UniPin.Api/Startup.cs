using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Application.Commands;
using Application.Commands.Category;
using Application.Commands.Comment;
using Application.Commands.Picture;
using Application.Commands.Post;
using Application.Commands.Rule;
using EFCommand;
using EFCommand.CategoryCommand;
using EFCommand.CommentCommand;
using EFCommand.PictureCommand;
using EFCommand.PostCommand;
using EFCommand.RuleCommand;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;
using UniPin.Api.Helpers;
using UniPin_DataAccess;

namespace UniPin.Api
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<UniPin_Context>();

            // UserCommand

            services.AddTransient<IGetUserCommand, EfGetUserCommand>();
            services.AddTransient<IGetAllUsersCommand,EfGetAllUsersCommand>();
            services.AddTransient<IDeleteUserCommand, EfDeleteUserCommand>();
            services.AddTransient<ICreateUserCommand, EfCreateUserCommand>();
            services.AddTransient<IUpdateUserCommand, EfUpdateUserCommand>();

            //CategoryCommand

            services.AddTransient<ICreateCategoryCommand, EfCreateCategoryCommand>();
            services.AddTransient<IGetAllCategoryCommand, EfGetAllCategoryCommand>();
            services.AddTransient<IGetOneCategoryCommand, EfGetOneCategoryCommand>();
            services.AddTransient<IDeleteCategoryCommand, EfDeleteCategoryCommand>();
            services.AddTransient<IUpdateCategoryCommand, EfUpdateCategoryCommand>();

            //RuleCommand

            services.AddTransient<ICreateRuleCommand, EfCreateRuleCommand>();
            services.AddTransient<IGetAllRuleCommand, EfGetAllRuleCommand>();
            services.AddTransient<IDeleteRuleCommand, EfDeleteRuleCommand>();
            services.AddTransient<IGetOneRuleCommand, EfGetOneRuleCommand>();
            services.AddTransient<IUpdateRuleCommand, EfUpdateRuleCommand>();

            //PictureCommand

            services.AddTransient<ICreatePictureCommand, EfCreatePictureCommand>();
            services.AddTransient<IGetAllPictureCommand, EfGetAllPictureCommand>();
            services.AddTransient<IGetPictureCommand, EfGetPictureCommand>();
            services.AddTransient<IUpdatePictureCommand, EfUpdatePictureCommand>();
            services.AddTransient<IDeletePictureCommand, EfDeletePictureCommand>();

            //PostCommand

            services.AddTransient<ICreatePostCommand, EfCreatePostCommand>();
            services.AddTransient<IGetAllPostCommand, EfGetAllPostCommand>();
            services.AddTransient<IGetOnePostCommand, EfGetOnePostCommand>();
            services.AddTransient<IDeletePostCommand, EfDeletePostCommand>();
            services.AddTransient<IUpdatePostCommand, EfUpdatePostCommand>();

            //CommentCommand

            services.AddTransient<IGetAllCommentCommand, EfGetAllCommentCommand>();
            services.AddTransient<IGetOneCommentCommand, EfGetOneCommentCommand>();
            services.AddTransient<ICreateCommentCommand, EfCreateCommentCommand>();
            services.AddTransient<IDeleteCommentCommand, EfDeleteCommentCommand>();
            services.AddTransient<IUpdateCommentCommand, EfUpdateCommentCommand>();

            services.AddTransient<IloggedUserCommand, EfLoggedUserCommand>();

            var key = Configuration.GetSection("Encryption")["key"];

            var enc = new Encryption(key);
            services.AddSingleton(enc);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "UniPin API", Version = "v1" });
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
       


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
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
            app.UseStaticFiles();

            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
        }
    }
}
