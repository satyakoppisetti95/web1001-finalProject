using System;
using Microsoft.AspNetCore.Mvc;
using finalProject.Models;
using CalculatorLibrary;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace finalProject.Controllers
{
    public class CalculatorController : Controller
    {

        SimpleCalc sc = new SimpleCalc();

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

            try
            {
                ViewBag.result = sc.OperatorSwitch(exp.operator_symbol, exp.operand1, exp.operand2).ToString("0.####");
            }catch(DivideByZeroException de)
            {
                Console.WriteLine(de.Message);
                ViewBag.result = "Error: Invalid divisor";
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                ViewBag.result = "Invalid Inputs";
            }
            
            return View();
        }
    }
}
