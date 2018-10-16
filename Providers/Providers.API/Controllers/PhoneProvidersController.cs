using Microsoft.AspNetCore.Mvc;
using Providers.Domain.Commands;
using Providers.Domain.Entities;
using Providers.Domain.Repository;
using Providers.LoggerService;
using System;
using System.Threading.Tasks;

namespace Providers.API.Controllers
{
    [Route("v1/company-providers")]
    public class PhoneProvidersController : Controller
    {
        private readonly IPhoneProvidersRepository _phoneProvidersRepository;
        private readonly ILoggerManager _logger;

        public PhoneProvidersController(IPhoneProvidersRepository phoneProvidersRepository, ILoggerManager logger)
        {
            _logger = logger;
            _phoneProvidersRepository = phoneProvidersRepository;
        }
        
        [HttpPost("{companyProvidersId}/phone-providers")]
        public async Task<IActionResult> Post([FromBody] PhoneProvidersCommands model, [FromRoute] int companyProvidersId)
        {
            if (model == null)
            {
                _logger.LogError("Phone Providers object sent from client is null.");
                return BadRequest("Phone Providers object is null");
            }
            
            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid Phone Providers object sent from client.");
                return BadRequest("Invalid model object");
            }
            var phoneProviders = await _phoneProvidersRepository.CreateAsync(new PhoneProviders(model.Phone, companyProvidersId));

            return Ok(phoneProviders);

            throw new Exception("Exception while fetching all the Phone Providers from the storage.");
            
        }
    }
}
