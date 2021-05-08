using Atlantic.Domain.Core.Bus;
using Atlantic.Infrastructure.Bus;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
namespace Atlantic.Infrastructure.IOC {
    public class DependencyContainer {
        public static void RegisterServices(IServiceCollection services) {
            //Domain Bus
            //services.AddTransient<IEventBus, RabbitMQBus>();
            services.AddSingleton<IEventBus, RabbitMQBus>(serviceProvider => {
                var mediator = serviceProvider.GetService<IMediator>();
                var scopeFactory = serviceProvider.GetRequiredService<IServiceScopeFactory>();
                return new RabbitMQBus(mediator, scopeFactory);
            });
            //subscription
            //services.AddTransient<TransferEventHandler>();
            //services.AddTransient<IEventHandler<TransferCreatedEvent>, TransferEventHandler>();
            //Domain Banking Commands
            //services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();
            //Application Services
            //services.AddTransient<IAccountService, AccountService>();
            //services.AddTransient<ITransferService, TransferService>();
            //Data
            //services.AddTransient<IAccountRepository, AccountRepository>();
            //services.AddTransient<ITransferRepository, TransferRepository>();
            //services.AddTransient<BankingDbContext>();
            //services.AddTransient<TransferDbContext>();
        }
    }
}
