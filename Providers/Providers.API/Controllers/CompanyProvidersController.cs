using Microsoft.AspNetCore.Mvc;
using Providers.Domain.Commands;
using Providers.Domain.Entities;
using Providers.Domain.Enum;
using Providers.Domain.Filter;
using Providers.Domain.Repository;
using Providers.LoggerService;
using System;
using System.Threading.Tasks;

namespace Providers.API.Controllers
{
    [Route("v1/company-providers")]
    public class CompanyProvidersController : Controller
    {
        private readonly ICompanyProvidersRepository _companyProvidersRepository;
        private readonly ILoggerManager _logger;

        public CompanyProvidersController(ICompanyProvidersRepository companyProvidersRepository, ILoggerManager logger)
        {
            _logger = logger;
            _companyProvidersRepository = companyProvidersRepository;
        }

        [HttpGet]       
        public async Task<IActionResult> GetAll(CompanyProvidersQuery CompanyProvidersQuery)
        {
            _logger.LogInfo("Fetching all the Company from the storage");

            var companyProviders = await _companyProvidersRepository.GetAll(CompanyProvidersQuery);

            _logger.LogInfo($"Returning Company.");

            return Ok(companyProviders);

            throw new Exception("Exception while fetching all the Company Providers from the storage.");
        }
 
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            var companyProviders = await _companyProvidersRepository.GetById(id);

            if (companyProviders == null)
            {
                _logger.LogError($"Company Providers with id: {id}, hasn't been found in db.");
                return NotFound();
            }
            else
            {
                _logger.LogInfo($"Returned Company Providers with details for id: {id}");
                return Ok(companyProviders);
            }

            throw new Exception("Exception while fetching all the Company Providers from the storage.");
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CompanyProvidersCommands model)
        {   
            var _companyProviders = await _companyProvidersRepository.GetByAsync(model);
            if (_companyProviders != null)
            {
                ModelState.AddModelError("cpF_CNPJ", "This cpf or cnpj already exists");
                return BadRequest(ModelState);
            }

            if (model.Ativo == false)
            {
                var companyProviders = new CompanyProviders(model.Name, model.CPF_CNPJ, model.Ativo, model.CompanyId);
                return Ok(await _companyProvidersRepository.CreateAsync(companyProviders));
            }
            else
            {

                if ((model.Company.UF == UF.PR) && (model.Age < 18))
                {
                    ModelState.AddModelError("age", "Natural person of Parané must be of legal age");
                    return BadRequest(ModelState);
                }

                var physicalPerson = new PhysicalPerson(model.Name, model.CPF_CNPJ, model.Ativo, model.CompanyId, model.DateBirth, model.RG, model.Age);
                return Ok(await _companyProvidersRepository.CreateAsync(physicalPerson));
            }

            throw new Exception("Exception while fetching all the Company Providers from the storage.");
        }
    }
}
