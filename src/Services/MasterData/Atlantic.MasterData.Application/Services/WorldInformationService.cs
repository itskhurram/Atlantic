using System.Collections.Generic;
using System.Threading.Tasks;

using Atlantic.MasterData.Application.Interfaces;
using Atlantic.MasterData.Domain.Interfaces;
using Atlantic.MasterData.Domain.Models;
namespace Atlantic.MasterData.Application.Services {
    public class WorldInformationService : IWorldInformationService {
        private readonly IWorldInformationRepository _worldInformationRepository;
        public WorldInformationService(IWorldInformationRepository worldInformationRepository) {
            _worldInformationRepository = worldInformationRepository;
        }
        public async Task<IEnumerable<Countries>> GetCountries() {
            return await _worldInformationRepository.GetCountries();
        }
        public async Task<IEnumerable<States>> GetStatesByCountryId(int CountryId) {
            return await _worldInformationRepository.GetStatesByCountryId(CountryId);
        }
        public async Task<IEnumerable<Cities>> GetCitiesByCountryStateId(int StateId, int CountryId) {
            return await _worldInformationRepository.GetCitiesByCountryStateId(StateId, CountryId);
        }
    }
}
