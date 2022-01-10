using Domain.ServiceExtensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadsAppp
{
    public class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<Form1>();
                var form2 = serviceProvider.GetRequiredService<Form2>();
                Application.Run(new Form1());
                Application.Run(new Form2());
            }

        }

        public static  void ConfigureServices(IServiceCollection services)
        {
            // public readonly IConfiguration configuration;

            services.AddScoped<Form1>();
            services.AddScoped<Form2>();
            //services.AddDomain(Configuration);
        }

    }
}



            /*private readonly IConfiguration _config;

            var startup = new Startup(_config);

            var recipeApp = startup.ConfigureServices().GetService<Application>();

            await recipeApp.StartAsync();*/
        
    


