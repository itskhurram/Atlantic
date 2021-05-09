using Atlantic.MasterData.Application.Interfaces;
using Atlantic.MasterData.Application.Services;
using Atlantic.MasterData.Data.Context;
using Atlantic.MasterData.Data.Repositories;
using Atlantic.MasterData.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
namespace Atlantic.Infrastructure.IOC.Container {
    public class DependencyContainer {
        public static void RegisterServices(IServiceCollection services) {
            #region Buss Related Code
            ////Domain Bus
            ////services.AddTransient<IEventBus, RabbitMQBus>();
            ////services.AddSingleton<IEventBus, RabbitMQBus>(serviceProvider => {
            ////    var mediator = serviceProvider.GetService<IMediator>();
            ////    var scopeFactory = serviceProvider.GetRequiredService<IServiceScopeFactory>();
            ////    return new RabbitMQBus(mediator, scopeFactory);
            ////});
            ////subscription
            ////services.AddTransient<TransferEventHandler>();
            ////services.AddTransient<IEventHandler<TransferCreatedEvent>, TransferEventHandler>();
            ////Domain Banking Commands
            ////services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();
            #endregion
            MasterDataServicesRegistion(services);
        }
        private static void MasterDataServicesRegistion(IServiceCollection services) {
            #region Application Services
            services.AddTransient<IBusinessServicesService, BusinessServicesService>();
            services.AddTransient<IWorldInformationService, WorldInformationService>();
            #endregion
            #region Data Repositories
            services.AddTransient<IBusinessServicesRepository, BusinessServicesRepository>();
            services.AddTransient<IWorldInformationRepository, WorldInformationRepository>();
            services.AddTransient<MasterDataContext>();
            #endregion
        }
    }
}
