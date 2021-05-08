using Atlantic.MasterData.Data.Context;
using Atlantic.MasterData.Data.DataSeed;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atlantic.MasterData.API {
    public class Program {
        public static void Main(string[] args) {
            CreateHostBuilder(args).Build().Run();
        }
        //public static async Task Main(string[] args) {
        //    var mainHost = CreateHostBuilder(args).Build();
        //    using var scope = mainHost.Services.CreateScope();
        //    var services = scope.ServiceProvider;
        //    try {
        //        var context = services.GetRequiredService<MasterDataContext>();
        //        await context.Database.MigrateAsync();
        //        await SeedMasterData.SeedData(context);
        //    }
        //    catch (Exception exception) {
        //        var logger = services.GetRequiredService<ILogger<Program>>();
        //        logger.LogError(exception, "Error Occured During Master Data Migration.");
        //    }
        //    await mainHost.RunAsync();
        //}
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
