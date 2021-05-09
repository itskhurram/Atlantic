using Atlantic.MasterData.Application.Interfaces;
using Atlantic.MasterData.Domain.Interfaces;
using Atlantic.MasterData.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Atlantic.MasterData.Application.Services {
    public class BusinessServicesService : IBusinessServicesService {
        private readonly IBusinessServicesRepository _businessServicesRepository;
        public BusinessServicesService( IBusinessServicesRepository businessServicesRepository) {
            _businessServicesRepository = businessServicesRepository;
        }
        public async Task<IEnumerable<BusinessServices>> GetBusinessServices() {
            return await _businessServicesRepository.GetBusinessServices();
        }
    }
}
