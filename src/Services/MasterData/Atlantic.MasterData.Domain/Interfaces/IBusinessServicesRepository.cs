using Atlantic.MasterData.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Atlantic.MasterData.Domain.Interfaces {
    public interface IBusinessServicesRepository {
        Task<IEnumerable<BusinessServices>> GetBusinessServices();
    }
}
