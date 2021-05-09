using Atlantic.MasterData.Application.Interfaces;
using Atlantic.MasterData.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Atlantic.MasterData.API.Controllers {
    [ApiController]
    [Route("api/v1/[controller]")]
    public class BusinessServicesController : ControllerBase {
        private readonly IBusinessServicesService _businessServicesService;
        public BusinessServicesController(IBusinessServicesService businessServicesService) {
            _businessServicesService = businessServicesService;
        }

        [HttpGet]
        public async Task<IEnumerable<BusinessServices>> Get() {
            return await _businessServicesService.GetBusinessServices();
        }
    }
}
