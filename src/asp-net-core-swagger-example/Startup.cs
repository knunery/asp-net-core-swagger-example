using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace asp_net_core_swagger_example
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddSwaggerGen();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();

            app.UseSwagger();
            app.UseSwaggerUi();
        }
    }
}
