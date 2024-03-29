﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CentricExpress.Business;
using CentricExpress.Business.Models;
using CentricExpress.Data;
using CentricExpress.Data.Entities;
using CentricExpress.Data.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Swagger;

namespace CentricExpress.Api
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "Centric Express", Version = "v1" });
            });

            services.AddEntityFrameworkSqlServer()
                .AddDbContext<SuperheroesContext>(options => 
                    options.UseSqlServer(Configuration.GetConnectionString("SuperheroesConn")));

            services.AddScoped<ISuperheroBusiness, SuperheroBusiness>();
            services.AddScoped<ISuperheroRepository, EntityFrameworkSuperheroRepository>();
            services.AddScoped<IDatabase, Database>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Centric Express");
            });

            app.UseMvc();
        }
    }
}
