using Microsoft.AspNetCore.Mvc;
using Providers.Domain.Commands;
using Providers.Domain.Entities;
using Providers.Domain.Repository;
using Providers.LoggerService;
using System;
using System.Threading.Tasks;

namespace Providers.API.Controllers
{

    [Route("v1/company")]
    public class CompanyController : Controller
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly ILoggerManager _logger;

        public CompanyController(ICompanyRepository companyRepository, ILoggerManager logger)
        {
            _logger = logger;
            _companyRepository = companyRepository;
            
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            _logger.LogInfo("Fetching all the Company from the storage");

            var company = await _companyRepository.GetAll();

            _logger.LogInfo($"Returning Company.");
            
            return Ok(company);

            throw new Exception("Exception while fetching all the Company from the storage.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            var company = await _companyRepository.GetById(id);

            if (company == null)
            {
                _logger.LogError($"Company with id: {id}, hasn't been found in db.");
                return NotFound();
            }
            else
            {
                _logger.LogInfo($"Returned Company with details for id: {id}");
                return Ok(company);
            }

            throw new Exception("Exception while fetching all the Company from the storage.");
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CompanyCommands model)
        {
            if (model == null)
            {
                _logger.LogError("Company object sent from client is null.");
                return BadRequest("Phone Providers object is null");
            }
            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid Company object sent from client.");
                return BadRequest("Invalid model object");
            }

            var company = await _companyRepository.CreateAsync(new Company(model.FantasyName, model.CNPJ, model.UF));

            return Ok(company);

            throw new Exception("Exception while fetching all the Company from the storage.");
        }
    }
}
