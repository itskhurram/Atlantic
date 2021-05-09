using System.Collections.Generic;
using System.Threading.Tasks;
using Atlantic.MasterData.Application.Interfaces;
using Atlantic.MasterData.Domain.Models;
using Microsoft.AspNetCore.Mvc;
namespace Atlantic.MasterData.API.Controllers {
    public class WorldInformationController : BaseApiV1Controller {
        private readonly IWorldInformationService _worldInformationService;
        public WorldInformationController(IWorldInformationService worldInformationService) {
            _worldInformationService = worldInformationService;
        }
        [HttpGet]
        public async Task<IEnumerable<Countries>> GetCountries() {
            return await _worldInformationService.GetCountries();
        }
        [HttpGet]
        public async Task<IEnumerable<States>> GetStatesByCountry(int CountryId) {
            return await _worldInformationService.GetStatesByCountryId(CountryId);
        }
        [HttpGet]
        public async Task<IEnumerable<Cities>> GetCitiesByCountryState(int StateId, int CountryId) {
            return await _worldInformationService.GetCitiesByCountryStateId(StateId, CountryId);
        }
    }
}
