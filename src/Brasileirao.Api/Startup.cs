using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Infra.Repositories;
using Brasileirao.Data;
using Brasileirao.Data.Repositories;
using Brasileirao.Data.Interfaces;
using Brasileirao.Services.Players;
using Brasileirao.Services.Teams;
using Brasileirao.Services.Users;
using Brasileirao.Api.Middlewares;
using Brasileirao.Api.Configurations;
using Microsoft.OpenApi.Models;

namespace Brasileirao.Api
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
            
            services.AddCors();

            services.AddMvcConfiguration();

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUsersRepository, UsersRepository>();
            services.AddScoped<IUsersService, UsersService>();

            services.AddScoped<ITeamsRepository, TeamsRepository>();
            services.AddScoped<ITeamsService, TeamsService>();

            services.AddScoped<ITeamPlayersRepository, TeamPlayersRepository>();
            
            services.AddScoped<IPlayersRepository, PlayersRepository>();
            services.AddScoped<IPlayersService, PlayersService>();
            services.AddDbContext<BrasileiraoContext>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Brasileirao.Api", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            using (var db = new BrasileiraoContext())
            {
                db.Database.Migrate();
            }

            app.UseMiddleware<ExceptionHandlerMiddleware>();

            app.UseCors(builder =>
            {
                builder.AllowAnyOrigin();
                builder.AllowAnyMethod();
                builder.AllowAnyHeader();
            });

            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Brasileirao.Api v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
