using Atlantic.MasterData.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
namespace Atlantic.MasterData.Data.DataSeed {
    public class SeedMasterData {
        public static async Task SeedData(MasterDataContext masterDataContext) {
            
            if (await masterDataContext.Countries.AnyAsync()) return;
            if (await masterDataContext.States.AnyAsync()) return;
            if (await masterDataContext.Cities.AnyAsync()) return;
            if (await masterDataContext.BusinessServices.AnyAsync()) return;



            var businessServiceInsertQueries = await System.IO.File.ReadAllTextAsync("Data/BusinessService.sql");
            await masterDataContext.Database.ExecuteSqlRawAsync(businessServiceInsertQueries);

            var countriesInsertQuery = await System.IO.File.ReadAllTextAsync("Data/CountriesScript.sql");
            await masterDataContext.Database.ExecuteSqlRawAsync(countriesInsertQuery);

            var statesInsertQuery = await System.IO.File.ReadAllTextAsync("Data/StatesScript.sql");
            await masterDataContext.Database.ExecuteSqlRawAsync(statesInsertQuery);

            //var CityInsertQueries01 = await System.IO.File.ReadAllTextAsync("Data/CitiesScript.sql");
            var CityInsertQueries01 = await System.IO.File.ReadAllLinesAsync("Data/CitiesScript.sql");
            await  masterDataContext.Database.BeginTransactionAsync();
            foreach (var line in CityInsertQueries01) {
                if(!string.IsNullOrEmpty(line))
                    await masterDataContext.Database.ExecuteSqlRawAsync(line);

            }
            await masterDataContext.Database.CommitTransactionAsync();



            await masterDataContext.SaveChangesAsync();
        }
    }
}
