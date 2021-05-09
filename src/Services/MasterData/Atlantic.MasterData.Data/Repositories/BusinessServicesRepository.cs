using Atlantic.MasterData.Data.Context;
using Atlantic.MasterData.Domain.Interfaces;
using Atlantic.MasterData.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Atlantic.MasterData.Data.Repositories {
    public class BusinessServicesRepository : IBusinessServicesRepository {
        private readonly MasterDataContext _masterDataContext;
        public BusinessServicesRepository(MasterDataContext masterDataContext) {
            _masterDataContext = masterDataContext;
        }
        public async Task<IEnumerable<BusinessServices>> GetBusinessServices() {
            try {
                return await _masterDataContext.BusinessServices.ToListAsync();
            }
            catch (Exception) {
                return null;
            }
        }
    }
}
