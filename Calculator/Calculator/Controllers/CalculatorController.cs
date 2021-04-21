using Calculator.BusinessLogic;
using Calculator.BusinessLogic.Builders;
using Calculator.BusinessLogic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.IO;

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
            _calculatorService = calculatorService; ;
        }

        [HttpGet]
        [Route("operations/combinedWith")]
        public double CombinedWith(double first, double second)
        {
            var expression = _operationBuilder.BuildCombinedWith(first, second);

            var gg = expression.evaluate();

            return gg;
        }

        [HttpGet]
        [Route("operations/either")]
        public double Either(double first, double second)
        {
            var g1g = _calculatorService.getEither(first, second);

            return g1g;
        }
    }
}
