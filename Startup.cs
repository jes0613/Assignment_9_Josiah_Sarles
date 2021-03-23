using Assignment_9_Josiah_Sarles.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_9_Josiah_Sarles
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

            services.AddDbContext<MoviesDbContext>(options =>
            {
                options.UseSqlite(Configuration["ConnectionStrings:MoviesConnection"]);
            });

            // Heres the second service added
            services.AddScoped<IMoviesRepo, EFMoviesRepo>();
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
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    "home",
                    "Homepage",
                    new { Controller = "Home", action = "Index" }
                    );

                endpoints.MapControllerRoute(
                    "enterFilm",
                    "AddMovie",
                    new { Controller = "Home", action = "EnterFilm" }
                    );

                endpoints.MapControllerRoute(
                    "editFilm",
                    "EditMovie",
                    new { Controller = "Home", action = "EditFilm" }
                    );

                endpoints.MapControllerRoute(
                    "viewFilms",
                    "ViewMovies",
                    new { Controller = "Home", action = "FilmList" }
                    );

                endpoints.MapControllerRoute(
                    "podcasts",
                    "Podcasts",
                    new { Controller = "Home", action = "Podcasts" }
                    );

                endpoints.MapControllerRoute(
                    "confirmEdit",
                    "EditConfirmed",
                    new { Controller = "Home", action = "ConfirmEdit" }
                    );

                endpoints.MapControllerRoute(
                    "confirmDelete",
                    "DeleteConfirmed",
                    new { Controller = "Home", action = "ConfirmDelete" }
                    );

                endpoints.MapControllerRoute(
                    "confirmAdd",
                    "AddConfirmed",
                    new { Controller = "Home", action = "ConfirmAdd" }
                    );

                endpoints.MapDefaultControllerRoute();
            });


            //Seed data function
            SeedData.EnsurePopulated(app);
        }
    }
}
