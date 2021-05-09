
using Atlantic.MasterData.Application.Interfaces;
using Atlantic.MasterData.Application.Services;
using Atlantic.MasterData.Data.Context;
using Atlantic.MasterData.Data.Repositories;
using Atlantic.MasterData.Domain.Interfaces;

using Microsoft.Extensions.DependencyInjection;

namespace Atlantic.MasterData.Infrastructure.Container {
    public class DependencyContainer {
        public static void RegisterServices(IServiceCollection services) {
            ApplicationServicesRegistion(services);
            DataServicesRegistion(services);
        }
        private static void ApplicationServicesRegistion(IServiceCollection services) {
            #region Application Services
            services.AddTransient<IBusinessServicesService, BusinessServicesService>();
            services.AddTransient<IWorldInformationService, WorldInformationService>();
            #endregion
        }
        private static void DataServicesRegistion(IServiceCollection services) {
            #region Data Repositories
            services.AddTransient<IBusinessServicesRepository, BusinessServicesRepository>();
            services.AddTransient<IWorldInformationRepository, WorldInformationRepository>();
            services.AddTransient<MasterDataContext>();
            #endregion
        }
    }
}
