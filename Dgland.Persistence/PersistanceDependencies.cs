
using Dgland.Persistence.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Dgland.Persistence
{
    public static class PersistanceDependencies
    {
        public static IServiceCollection AddPersistanceDependencies(this IServiceCollection services
            , IConfiguration configurtion)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configurtion.GetConnectionString("Dgland"), 
                    x => x.MigrationsAssembly("Dgland.WebApi"));
            });

            return services;
        }
    }
}
