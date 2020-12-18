using System;
namespace CalculatorLibrary
{
    public class SimpleCalc
    {

        public decimal Add(decimal leftNumber, decimal rightNumber) {
            return (leftNumber + rightNumber);
        }

        public decimal Subtract(decimal leftNumber, decimal rightNumber)
        {
            return leftNumber - rightNumber;
        }

        public decimal Multiply(decimal leftNumber, decimal rightNumber)
        {
            return leftNumber * rightNumber;
        }

        public decimal Divide(decimal leftNumber, decimal rightNumber)
        {
            //if (rightNumber != 0)
            //{
            //    return leftNumber * rightNumber;
            //}
            //else
            //{
            //    return Double.NaN;
            //}

            return leftNumber/rightNumber;
            
        }

        public decimal OperatorSwitch(string optr, decimal leftNumber, decimal rightNumber)
        {
            switch (optr)
            {
                case "+":
                    return Add(leftNumber, rightNumber);
                case "-":
                    return Subtract(leftNumber, rightNumber);
                case "*":
                    return Multiply(leftNumber, rightNumber);
                case "/":
                    return Divide(leftNumber, rightNumber);
                default:
                    return Add(leftNumber, rightNumber);
            }
        }

    }
}
