using Domain.ServiceExtensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadsAppp
{
    class Startup
    {
       /* public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }*/

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddDomain(Configuration);
            //services.AddSingleton<>();

            return services.BuildServiceProvider();
        }

        /*internal object ConfigureServices()
        {
            throw new NotImplementedException();
        }*/
    }
}
