using Atlantic.MasterData.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Atlantic.MasterData.Application.Interfaces {
    public interface IBusinessServicesService {
        Task<IEnumerable<BusinessServices>> GetBusinessServices();
    }
}
