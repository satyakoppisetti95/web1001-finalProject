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
            try
            {
                return leftNumber / rightNumber;
            }
            catch (DivideByZeroException)
            {
                throw new DivideByZeroException("Can't divide by zero");
            }
            
        }

        public string OperatorSwitch(string optr, decimal leftNumber, decimal rightNumber)
        {
 
            switch (optr)
            {
                case "+":
                    return Add(leftNumber, rightNumber).ToString("0.####");
                case "-":
                    return Subtract(leftNumber, rightNumber).ToString("0.####");
                case "*":
                    return Multiply(leftNumber, rightNumber).ToString("0.####");
                case "/":
                    try
                    {
                        return Divide(leftNumber, rightNumber).ToString("0.####");
                    }
                    catch (DivideByZeroException)
                    {
                        return "Error: Can't divide by zero";
                    }
                default:
                    return Add(leftNumber, rightNumber).ToString("0.####");
            }
        }

    }
}
