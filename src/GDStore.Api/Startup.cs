using FluentValidation.AspNetCore;
using GDStore.Application.Brands;
using GDStore.Application.Categories;
using GDStore.Application.ProductCategories;
using GDStore.Application.ProductImages;
using GDStore.Application.Products;
using GDStore.Application.Users;
using GDStore.Domain.Entities;
using GDStore.Infrastructure;
using GDStore.Infrastructure.Persistence;
using GDStore.ViewModel;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System.Collections.Generic;

namespace GDStore.Api
{
    public class Startup
    {
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var clientUrls = new Dictionary<string, string>
            {
                ["Mvc"] = Configuration["ClientUrl:Mvc"],
                ["Swagger"] = Configuration["ClientUrl:Swagger"]
            };

            services.AddInfrastructure(Configuration);

            services.AddTransient<IBrandService, BrandService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IProductImageService, ProductImageService>();
            services.AddTransient<IProductCategoryService, ProductCategoryService>();
            services.AddTransient<UserManager<AppUser>, UserManager<AppUser>>();
            services.AddTransient<SignInManager<AppUser>, SignInManager<AppUser>>();
            services.AddTransient<RoleManager<AppRole>, RoleManager<AppRole>>();

            services.AddControllers().AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<RegisterValidator>());

            services.AddCors(options =>
            {
                options.AddPolicy(MyAllowSpecificOrigins,
                builder =>
                {
                    builder.WithOrigins(clientUrls["Mvc"])
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Swagger GDStore", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseRouting();

            app.UseAuthorization();
            app.UseStaticFiles();

            app.UseSwagger();

            app.UseSwaggerUI(c => 
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger GDStore V1");
            });

            app.UseCors(MyAllowSpecificOrigins);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
