using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;

namespace asp_net_core_swagger_example
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddSwaggerGen();
            services.ConfigureSwaggerGen(options => options.IncludeXmlComments(GetXmlCommentsPath()));
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();

            app.UseSwagger();
            app.UseSwaggerUi();
        }

        private string GetXmlCommentsPath()
        {
            var app = PlatformServices.Default.Application;
            return Path.Combine(app.ApplicationBasePath, Path.ChangeExtension(app.ApplicationName, "xml"));
        }
    }
}
