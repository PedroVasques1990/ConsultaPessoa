using System;
using AutoMapper;
using ConsultaPessoas.Application.Context;
using ConsultaPessoas.Application.Models;
using ConsultaPessoas.Domain.Interfaces;
using ConsultaPessoas.Repository.Classes;
using main;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ConsultaPessoas.Application
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddScoped<IPessoaRepository>(pessoa => new PessoaRepository(Configuration));

            //Mapeamento
            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Pessoa, PessoaViewModel>().ReverseMap();
                cfg.CreateMap<DateTime, string>().ConvertUsing(dt => dt.ToString("dd/MM/yyyy"));
            });
            
            IMapper mapper = config.CreateMapper();
            
            services.AddSingleton(mapper);
            
            //Contexto
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
