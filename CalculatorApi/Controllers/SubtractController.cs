using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalculatorLibrary;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalculatorApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SubtractController : ControllerBase
    {
        SimpleCalc calculator = new SimpleCalc();

        [HttpGet]
        public decimal Get([FromQuery] decimal leftNumber, [FromQuery] decimal rightNumber)
        {
            return calculator.Subtract(leftNumber, rightNumber);
        }

        [HttpPost]
        public decimal Post([FromForm] decimal leftNumber, [FromForm] decimal rightNumber)
        {
            return calculator.Subtract(leftNumber, rightNumber);
        }

        [HttpOptions]
        public dynamic Options([FromForm] decimal leftNumber, [FromForm] decimal rightNumber)
        {
            List<OptionObject> options = new List<OptionObject> { };
            options.Add(new OptionObject
            {
                method = "GET",
                info = "this method takes two decimal query parameters 'leftNumber' and 'rightNumber' and returns the difference of given decimals numbers",
                example = "GET request to /subtract/?leftNumber=2.3&rightNumber=1.2  gives result 1.1"
            });
            options.Add(new OptionObject { method = "POST", info = "this method takes two form properties 'leftNumber' and 'rightNumber' and returns the difference of given decimals numbers", example = "POST request to /subtract/ with formdata leftNumber=2.3 and rightNumber=1.2  gives result 1.1" });

            return options;
        }
    }
}
