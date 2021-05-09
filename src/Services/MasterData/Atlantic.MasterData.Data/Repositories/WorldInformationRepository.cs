using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Atlantic.MasterData.Data.Context;
using Atlantic.MasterData.Domain.Interfaces;
using Atlantic.MasterData.Domain.Models;

using Microsoft.EntityFrameworkCore;
namespace Atlantic.MasterData.Data.Repositories {
    public class WorldInformationRepository : IWorldInformationRepository {
        private readonly MasterDataContext _masterDataContext;
        public WorldInformationRepository(MasterDataContext masterDataContext) {
            _masterDataContext = masterDataContext;
        }
        public async Task<IEnumerable<Countries>> GetCountries() {
            try {
                return await _masterDataContext.Countries.Where(country => country.Flag == 1).ToListAsync();
            }
            catch (Exception) {
                return null;
            }
        }
        public async Task<IEnumerable<States>> GetStatesByCountryId(int CountryId) {
            try {
                return await _masterDataContext.States.Where(state => state.Flag == 1 && state.CountriesId == CountryId).ToListAsync();
            }
            catch (Exception) {
                return null;
            }
        }
        public async Task<IEnumerable<Cities>> GetCitiesByCountryStateId(int StateId, int CountryId) {
            try {
                return await _masterDataContext.Cities.Where(city => city.Flag == 1 &&
                                                             city.StatesId == StateId &&
                                                             city.CountriesId == CountryId).ToListAsync();
            }
            catch (Exception) {
                return null;
            }
        }
    }
}
