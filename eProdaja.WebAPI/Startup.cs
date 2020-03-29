using AutoMapper;
using eProdaja.Model;
using eProdaja.Model.Requests;
using eProdaja.WebAPI.Database;
using eProdaja.WebAPI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using JediniceMjere = eProdaja.WebAPI.Database.JediniceMjere;
using VrsteProizvoda = eProdaja.WebAPI.Database.VrsteProizvoda;

namespace eProdaja.WebAPI
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
            services.AddControllers();
            services.AddDbContext<eProdajaContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("eProdajaCS")));

            services.AddAutoMapper(typeof(Startup));

            services.AddSwaggerGen(x =>
                x.SwaggerDoc("v1", new OpenApiInfo { Title = "eProdajaAPI", Version = "v1" }));

            services.AddScoped<IKorisniciService, KorisniciService>();

            services
                .AddScoped<IService<Model.JediniceMjere , object>,
                    BaseService<Model.JediniceMjere, object, JediniceMjere>>();

            services
                .AddScoped<IService<Model.VrsteProizvoda , object>,
                    BaseService<Model.VrsteProizvoda , object, VrsteProizvoda>>();

            services
                .AddScoped<ICRUDService<Model.Proizvod, ProizvodSearchRequest,ProizvodUpsertRequest, ProizvodUpsertRequest>,
                    ProizvodService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = "";
            });

            app.UseRouting();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}