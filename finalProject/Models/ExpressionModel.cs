using System;
namespace finalProject.Models
{
    public class ExpressionModel
    {
        public decimal operand1 { get; set; }

        public decimal operand2 { get; set; }

        public string operator_symbol { get; set; }  //named operator_symbol as operator seems to be keyword

    }
}
