
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using rest.src.Models.Repository;
using rest.src.Models.ORM;

namespace rest.src.Models.DAO
{
    public static class AppDataModel
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration Configuration)
        {
            var DefaultConnection = Configuration.GetConnectionString("DefaultConnection");
            var ConnectionString = Configuration.GetConnectionString(DefaultConnection);

            switch (DefaultConnection)
            {
                case "SQLite":
                    ConnectionString = ConnectionString.Replace("|DataDirectory|", AppDomain.CurrentDomain.GetData("DataDirectory") as string);
                    services.AddDbContext<AppDbContext>(options => options.UseSqlite(ConnectionString));
                    break;

                case "MySQL":
                    //services.AddDbContext<AppDbContext>(options => options.UseMySql(ConnectionString));
                    break;

                default:
                    services.AddDbContext<AppDbContext>(options => options.UseSqlServer(ConnectionString));
                    break;
            }

            // add repositorys
            services.AddScoped<UserRepository>();
            services.AddScoped<RepositoryInterface<User>, UserRepository>();
        }
    }
}