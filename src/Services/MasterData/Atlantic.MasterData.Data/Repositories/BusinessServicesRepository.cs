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
        private readonly ILogger _logger;
        public BusinessServicesRepository(MasterDataContext masterDataContext,ILogger logger) {
            _masterDataContext = masterDataContext;
            _logger = logger;
        }
        public async Task<IEnumerable<BusinessServices>> GetBusinessServices() {
            try {
                return await _masterDataContext.BusinessServices.ToListAsync();
            }
            catch (Exception exception) {
                _logger.LogError(exception, "Error Occured during reading business services.");
                return null;
            }
        }
    }
}
