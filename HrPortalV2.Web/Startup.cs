﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HrPortalV2.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using HrPortalV2.Service;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace HrPortalV2.Web
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

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultUI();

            services.AddMvc().AddRazorPagesOptions(o => o.Conventions.AddAreaFolderRouteModelConvention("Identity", "/Account/", model => { foreach (var selector in model.Selectors) { var attributeRouteModel = selector.AttributeRouteModel; attributeRouteModel.Order = -1; attributeRouteModel.Template = attributeRouteModel.Template.Remove(0, "Identity".Length); } })).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddTransient<IEmailSender, EmailSender>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<IMessageService, MessageService>();
            services.AddTransient<IResumeService, ResumeService>();
            services.AddTransient<ICountyService, CountyService>();
            services.AddTransient<ISectorService, SectorService>();
            services.AddTransient<IResumeFileService, ResumeFileService>();
            services.AddTransient<IJobService, JobService>();
            services.AddTransient<IJobApplicationService, JobApplicationService>();
            services.AddTransient<IOccupationService, OccupationService>();
            services.AddTransient<ICityService, CityService>();
            services.AddTransient<ICompanyService, CompanyService>();
            services.AddTransient<ICountryService, CountryService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>()
                    .CreateScope())
            {
                serviceScope.ServiceProvider.GetService<ApplicationDbContext>()
                    .Database.EnsureCreated();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                   name: "areas",
                   template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                 );
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
