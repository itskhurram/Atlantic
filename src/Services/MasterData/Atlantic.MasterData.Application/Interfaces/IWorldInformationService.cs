using System.Collections.Generic;
using System.Threading.Tasks;

using Atlantic.MasterData.Domain.Models;

namespace Atlantic.MasterData.Application.Interfaces {
    public interface IWorldInformationService {
        Task<IEnumerable<Countries>> GetCountries();
        Task<IEnumerable<States>> GetStatesByCountryId(int CountryId);
        Task<IEnumerable<Cities>> GetCitiesByCountryStateId(int StateId, int CountryId);
    }
}
