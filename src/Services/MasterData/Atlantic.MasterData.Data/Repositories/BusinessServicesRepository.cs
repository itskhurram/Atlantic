using System.Collections.Generic;
using System.Threading.Tasks;

using Atlantic.MasterData.Data.Context;
using Atlantic.MasterData.Domain.Interfaces;
using Atlantic.MasterData.Domain.Models;

using Microsoft.EntityFrameworkCore;
namespace Atlantic.MasterData.Data.Repositories {
    public class BusinessServicesRepository : IBusinessServicesRepository {
        private readonly MasterDataContext _masterDataContext;
        public BusinessServicesRepository(MasterDataContext masterDataContext) {
            _masterDataContext = masterDataContext;
        }
        public async Task<IEnumerable<BusinessServices>> GetBusinessServices() {
            return await _masterDataContext.BusinessServices.ToListAsync();
        }
    }
}
