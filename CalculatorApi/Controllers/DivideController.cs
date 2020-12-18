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
    public class DivideController : ControllerBase
    {
        SimpleCalc calculator = new SimpleCalc();

        [HttpGet]
        public string Get([FromQuery] decimal leftNumber, [FromQuery] decimal rightNumber)
        {
            try
            {
                return calculator.Divide(leftNumber, rightNumber).ToString("0.#######");
            }
            catch (DivideByZeroException)
            {
                return "Error: Can't divide by zero";
            }
            
        }

        [HttpPost]
        public string Post([FromForm] decimal leftNumber, [FromForm] decimal rightNumber)
        {
            try
            {
                return calculator.Divide(leftNumber, rightNumber).ToString("0.#######");
            }
            catch (DivideByZeroException)
            {
                return "Error: Can't divide by zero";
            }
        }

        [HttpOptions]
        public dynamic Options([FromForm] decimal leftNumber, [FromForm] decimal rightNumber)
        {
            List<OptionObject> options = new List<OptionObject> { };
            options.Add(new OptionObject
            {
                method = "GET",
                info = "this method takes two decimal query parameters 'leftNumber' and 'rightNumber' and returns the division result of given decimals numbers",
                example = "GET request to /divide/?leftNumber=6&rightNumber=2  gives result 3"
            });
            options.Add(new OptionObject { method = "POST", info = "this method takes two form properties 'leftNumber' and 'rightNumber' and returns the division result of given decimals numbers", example = "POST request to /divide/ with formdata leftNumber=6 and rightNumber=2  gives result 3" });

            return options;
        }
    }
}
