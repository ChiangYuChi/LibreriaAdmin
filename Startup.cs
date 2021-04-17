﻿using LibreriaAdmin.Interfaces;
using LibreriaAdmin.Models;
using LibreriaAdmin.Repository;
using LibreriaAdmin.Repository.Interface;
using LibreriaAdmin.Services;
using LibreriaAdmin.ViewModels;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using NSwag;
using NSwag.Generation.Processors.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaAdmin
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
            services.AddControllersWithViews();

            //樓�蕎ibreriaContext
            services.AddDbContext<LibreriaDatabaseContext>(options => options.UseSqlServer(Configuration.GetConnectionString("LibreriaDataBaseContext")));

            //註冊Redis
            services.AddDistributedRedisCache(options =>
            {
                options.Configuration = Configuration["RedisConfig:LibreriaMemoryCache"];
            });

            //樓�蕮emberService
            services.AddTransient<IManagerService, ManagerService>();

            services.AddTransient<IMemberService, MemberService>();
            //
            services.AddTransient<ICategoryService, CategoryService>();


            //樓�蕧roductService
            services.AddTransient<IProductService, ProductService>();

            //注入OrderService
            services.AddTransient<IOrderService, OrderService>();

            //repository signup
            services.AddTransient<IRepository, LibreriaRepository>();

            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                               .AllowAnyMethod()
                               .AllowAnyHeader()
                               .WithExposedHeaders("*");
                    });
            });

            services.AddSwaggerDocument(config =>
            {
                var apiSchema = new OpenApiSecurityScheme()
                {
                    Type = OpenApiSecuritySchemeType.ApiKey,
                    Name = "授權欄位",
                    In = OpenApiSecurityApiKeyLocation.Header,
                    Description = "請將token 填入欄位:Bearer{Token}"
                };
                config.AddSecurity("JWT Token", Enumerable.Empty<string>(), apiSchema);
                config.OperationProcessors.Add(new AspNetCoreOperationSecurityScopeProcessor("JWT Token"));
            });

            services.AddAuthentication()
                     .AddCookie(options =>
                     {
                         options.LoginPath = "/Manager/login";
                         options.LogoutPath = "/Manager/login";
                         options.AccessDeniedPath = "/Account/Forbidden/";
                     })
                    .AddJwtBearer(options =>
                    {
                        options.RequireHttpsMetadata = false;
                        options.SaveToken = true;
                        options.TokenValidationParameters = new TokenValidationParameters()
                        {
                            ValidateIssuer = true,
                            ValidateAudience = true,
                            ValidateLifetime = true,
                            ValidateIssuerSigningKey = true,
                            ValidIssuer = Configuration["Jwt:Issuer"],
                            ValidAudience = Configuration["Jwt:Issuer"],
                            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))

                        };
                    });

            services.AddTransient<IExhibitonService, ExhibitonService>();
            services.AddTransient<IMemoryCacheRepository, MemoryCacheRepository>();

            services.AddRazorPages().AddRazorRuntimeCompilation();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseOpenApi();

            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseSwaggerUi3();

            app.UseRouting();

            app.UseCors();

            app.UseAuthentication();

            #region 若要控制Server response的控制，請取消註解並修改此段程式
            //app.UseStatusCodePages(async context =>
            //{
            //    var request = context.HttpContext.Request;
            //    var response = context.HttpContext.Response;

            //    if (response.StatusCode == (int)HttpStatusCode.Unauthorized)
            //    {
            //        response.Redirect("/Manager/login");
            //    }
            //});
            #endregion 

            app.UseCookiePolicy();


            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
