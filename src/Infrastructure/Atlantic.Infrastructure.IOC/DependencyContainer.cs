using Atlantic.Domain.Core.Bus;
using Atlantic.Infrastructure.Bus;
using Atlantic.MasterData.Application.Interfaces;
using Atlantic.MasterData.Application.Services;
using Atlantic.MasterData.Data.Context;
using Atlantic.MasterData.Data.Repositories;
using Atlantic.MasterData.Domain.Interfaces;

using MediatR;
using Microsoft.Extensions.DependencyInjection;
namespace Atlantic.Infrastructure.IOC {
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

            MasterServicesRegistion(services);
        }

        private static void MasterServicesRegistion(IServiceCollection services) {

            #region Application Services
            services.AddTransient<IBusinessServicesService, BusinessServicesService>();
            #endregion

            #region Data Repositories
            services.AddTransient<IBusinessServicesRepository, BusinessServicesRepository>();
            services.AddTransient<MasterDataContext>();
            #endregion

        }
    }
}
