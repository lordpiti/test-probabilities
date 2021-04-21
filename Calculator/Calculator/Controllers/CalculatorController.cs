using Calculator.BusinessLogic;
using Calculator.BusinessLogic.Builders;
using Calculator.BusinessLogic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Calculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;
        private readonly IOperationBuilder _operationBuilder;
        private readonly ICalculatorService _calculatorService;

        public CalculatorController(ILogger<CalculatorController> logger, IOperationBuilder operationBuilder, ICalculatorService calculatorService)
        {
            _logger = logger;
            _operationBuilder = operationBuilder;
            _calculatorService = calculatorService;
        }

        [HttpGet]
        [Route("operations/combinedWith")]
        public double CombinedWith(double first, double second)
        {
            var result = _calculatorService.getCombinedWith(first, second);

            return result;
        }

        [HttpGet]
        [Route("operations/either")]
        public double Either(double first, double second)
        {
            var result = _calculatorService.getEither(first, second);

            return result;
        }
    }
}
