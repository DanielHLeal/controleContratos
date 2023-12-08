using GerenciarContratos.Aplication.Services;
using GerenciarContratos.Data.DBContext;
using GerenciarContratos.Data.Repositories;
using GerenciarContratos.Domain.Interfaces;
using GerenciarContratos.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarContratos.Ioc
{
    public static class Bootstrap
    {
        public static ServiceCollection AddConfigDataBase(ServiceCollection services)
        {
            services.AddDbContext<Context>(options => options.UseSqlServer("Server=DESKTOP-AJV45NP;Database=database02;Trusted_Connection=True;TrustServerCertificate=True"));
            return services;
        }


        public static ServiceCollection ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<IBaseRepository, BaseRepository>();
            services.AddScoped<ILoginRepository, LoginRepository>();
            services.AddScoped<ILoginService, LoginService>();

            return services;

        }

        public static ServiceCollection HelperAddForm<TForm>(ServiceCollection services) where TForm : class
        {
            services.AddTransient<TForm>();
            services.AddSingleton<Func<TForm>>(x => () => x.GetService<TForm>()!);

            services.AddSingleton<IAbstractFactory<TForm>, AbstractFactory<TForm>>();

            return services;
        }
    }
}
