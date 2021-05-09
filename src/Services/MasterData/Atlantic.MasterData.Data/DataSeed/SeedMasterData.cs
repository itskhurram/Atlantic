﻿using Atlantic.MasterData.Data.Context;
using Atlantic.MasterData.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Atlantic.MasterData.Data.DataSeed {
    public class SeedMasterData {

        public static async Task SeedData(MasterDataContext masterDataContext) {
            if (await masterDataContext.Countries.AnyAsync()) return;
            if (await masterDataContext.States.AnyAsync()) return;
            if (await masterDataContext.Cities.AnyAsync()) return;
            var countriesInsertQuery = await System.IO.File.ReadAllTextAsync("Data/CountriesDataInsertScript.sql");
            await masterDataContext.Database.ExecuteSqlRawAsync(countriesInsertQuery);
            var statesInsertQuery = await System.IO.File.ReadAllTextAsync("Data/StatesDataInsertScript.sql");
            await masterDataContext.Database.ExecuteSqlRawAsync(statesInsertQuery);
            var CityInsertQueries = await System.IO.File.ReadAllTextAsync("Data/CitiesDataInsertScript.sql");
            await masterDataContext.Database.ExecuteSqlRawAsync(CityInsertQueries);

            await masterDataContext.SaveChangesAsync();
        }
    }
}
