using Atlantic.MasterData.Infrastructure.Container;
using Atlantic.MasterData.Infrastructure.Extensions;
using Atlantic.MasterData.Infrastructure.Middleware;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
namespace Atlantic.MasterData.API {
    public class Startup {
        private readonly IConfiguration _configuration; 
        public Startup(IConfiguration config) {
            _configuration = config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            services.AddApplicationServices(_configuration);
            services.AddControllers();
            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Atlantic.MasterData.API", Version = "v1" });
            });
            RegisterServices(services);
        }
        private void RegisterServices(IServiceCollection services) {
            DependencyContainer.RegisterServices(services);
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            app.UseMiddleware<ExceptionMiddleware>();
            if (env.IsDevelopment()) {
                //app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Atlantic.MasterData.API v1"));
            }
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
        }
    }
}
