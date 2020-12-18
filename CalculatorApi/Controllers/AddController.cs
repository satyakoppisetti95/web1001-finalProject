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
    public class AddController : ControllerBase
    {

        SimpleCalc calculator = new SimpleCalc();

        [HttpGet]
        public decimal Get([FromQuery] decimal leftNumber, [FromQuery] decimal rightNumber)
        {
            return calculator.Add(leftNumber,rightNumber);
        }

        [HttpPost]
        public decimal Post([FromForm] decimal leftNumber, [FromForm] decimal rightNumber)
        {
            return calculator.Add(leftNumber, rightNumber);
        }

        [HttpOptions]
        public dynamic Options([FromForm] decimal leftNumber, [FromForm] decimal rightNumber)
        {
            List<OptionObject> options = new List<OptionObject> { };
            options.Add(new OptionObject { method = "GET", info = "this method takes two decimal query parameters 'leftNumber' and 'rightNumber' and returns the sum of given decimals numbers",
            example="GET request to /add/?leftNumber=1.2&rightNumber=2.3  gives result 3.5"});
            options.Add(new OptionObject { method = "POST", info = "this method takes two form properties 'leftNumber' and 'rightNumber' and returns the sum of given decimals numbers", example = "POST request to /add/ with formdata leftNumber=1.2 and rightNumber=2.3  gives result 3.5" });

            return options;
        }
    }
}
