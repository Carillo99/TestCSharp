using Microsoft.AspNetCore.Mvc;
using Providers.API.Controllers;
using Providers.Domain.Repository;
using Providers.LoggerService;
using Xunit;

namespace Providers.Tests.ControllerTest
{
    public class CompanyControllerTest
    {
        CompanyController _controller;
        readonly ILoggerManager _logger;
        readonly ICompanyRepository _companyRepository;

        public CompanyControllerTest(ICompanyRepository companyRepository, ILoggerManager logger)
        {
            _companyRepository = companyRepository;
            _logger = logger;
            _controller = new CompanyController(_companyRepository, _logger);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.GetAll();

            // Assert
            Assert.IsType<OkObjectResult>(okResult.Result);
        }
    }
}
