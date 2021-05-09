
using Atlantic.MasterData.Data.Context;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Atlantic.Infrastructure.IOC.Extensions {
    public static class ApplicationServiceExtensions {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration) {

            #region MasterData Services
                services.AddDbContext<MasterDataContext>(options => {
                    options.UseSqlite(configuration.GetConnectionString("MasterDataDbConnection"));
                }); 
            #endregion

            return services;
        }
    }
}
