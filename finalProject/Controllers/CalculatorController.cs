using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using finalProject.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace finalProject.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ExpressionModel exp)
        {
            ViewBag.operand1 = exp.operand1;
            ViewBag.operand2 = exp.operand2;
            ViewBag.operator_symbol = exp.operator_symbol;

            switch (exp.operator_symbol)
            {
                case "+":
                    ViewBag.result = (exp.operand1 + exp.operand2).ToString("0.####");
                    break;
                case "-":
                    ViewBag.result = (exp.operand1 - exp.operand2).ToString("0.####");
                    break;
                case "*":
                    ViewBag.result = (exp.operand1 * exp.operand2).ToString("0.####");
                    break;
                case "/":
                    if (exp.operand2 != 0)
                    {
                        ViewBag.result = (exp.operand1 / exp.operand2).ToString("0.#######");
                    }
                    else
                    {
                        ViewBag.result = "Error : Can't Divide by zero";
                    }
                    break;
                default:
                    ViewBag.result = (exp.operand1 + exp.operand2).ToString("0.####");
                    break;
            }
            return View();
        }
    }
}
