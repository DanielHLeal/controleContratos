using GerenciarContratos.Ioc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WindowsFormsApp1;

namespace GerenciarContratos
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        
        
        
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            var services = new ServiceCollection();

            Bootstrap.ConfigureServices(services);
            Bootstrap.AddConfigDataBase(services);
            services.AddSingleton<Login>();
            services.AddSingleton<Menu>();
            services.AddSingleton<CadastroPessoas>();

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<Login>();
                Application.Run(form1);
            }
        }
        
    }
}