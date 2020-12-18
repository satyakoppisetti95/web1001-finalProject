using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;
using System;
namespace CalculatorTests
{
    [TestClass]
    public class UnitTest1
    {
        SimpleCalc calculator = new SimpleCalc();

        //=======ADDITION TESTS =========================

        [TestMethod]
        public void TestAddingTwoPositiveNumbers()
        {
            decimal leftNumber = 1M;
            decimal rightNumber = 2M;
            decimal expected = leftNumber + rightNumber;

            decimal actual = calculator.Add(leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestAddingTwoNegativeNumbers()
        {
            decimal leftNumber = -5M;
            decimal rightNumber = -3M;
            decimal expected = leftNumber + rightNumber;

            decimal actual = calculator.Add(leftNumber, rightNumber );

            Assert.AreEqual(expected, actual);

        }


        //one of the properties in addition is if you add 0 to a number the result should be equal to the number itself
        [TestMethod]
        public void TestAddingNumberToZeroAndCheckResultIsNumberItself()
        {
            decimal leftNumber = 25M;
            decimal rightNumber = 0M;
            decimal expected = leftNumber;

            decimal actual = calculator.Add(leftNumber, rightNumber );

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAddingOnePositiveOneNegativeNumbers()
        {
            decimal leftNumber = 1M;
            decimal rightNumber = -2M;
            decimal expected = leftNumber + rightNumber;

            decimal actual = calculator.Add(leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestAddingTwoDecimalNumbers()
        {
            decimal leftNumber = 1.23M;
            decimal rightNumber = 2.45M;
            decimal expected = leftNumber + rightNumber;

            decimal actual = calculator.Add(leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestAddingTwoNegativeDecimalNumbers()
        {
            decimal leftNumber = -5.26M;
            decimal rightNumber = -2.54M;
            decimal expected = leftNumber + rightNumber;

            decimal actual = calculator.Add(leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestAddingOnePositiveOneNegativeDecimalNumbers()
        {
            decimal leftNumber = 5.23M;
            decimal rightNumber = -4.34M;
            decimal expected = leftNumber + rightNumber;

            decimal actual = calculator.Add(leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestAddingPostiveDecimalToZeroAndCheckResultIsNumberItself()
        {
            decimal leftNumber = 2.345M;
            decimal rightNumber = 0M;
            decimal expected = leftNumber;

            decimal actual = calculator.Add(leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAddingNegativeDecimalToZeroAndCheckResultIsNumberItself()
        {
            decimal leftNumber = -13.445M;
            decimal rightNumber = 0M;
            decimal expected = leftNumber;

            decimal actual = calculator.Add(leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAddingTwoZeros()
        {
            decimal leftNumber = 0M;
            decimal rightNumber = 0M;
            decimal expected = leftNumber;

            decimal actual = calculator.Add(leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);
        }


        //=======SUBTRACTION TESTS =========================

        [TestMethod]
        public void TestSubtractingTwoPositiveNumbers()
        {
            decimal leftNumber = 25.0M;
            decimal rightNumber = 35.0M;
            decimal expected = leftNumber - rightNumber;

            decimal actual = calculator.Subtract(leftNumber, rightNumber );

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSubtractingTwoNegativeNumbers()
        {
            decimal leftNumber = -45.0M;
            decimal rightNumber = -55.0M;
            decimal expected = leftNumber - rightNumber;

            decimal actual = calculator.Subtract(leftNumber, rightNumber );

            Assert.AreEqual(expected, actual);

        }


        //one of the properties in subtraction is if you subtract a number from itself it should result in 0
        [TestMethod]
        public void TestSubtractingNumberByItself()
        {
            decimal leftNumber = 45.0M;
            decimal rightNumber = leftNumber;

            //expected should be 0
            decimal expected = 0;

            decimal actual = calculator.Subtract(leftNumber, rightNumber );

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestSubtractingOnePostiveOneNegativeNumbers()
        {
            decimal leftNumber = 45M;
            decimal rightNumber = -55M;
            decimal expected = leftNumber - rightNumber;

            decimal actual = calculator.Subtract(leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestSubtractingTwoDecimalNumbers()
        {
            decimal leftNumber = 45.234M;
            decimal rightNumber = 25.99M;
            decimal expected = leftNumber - rightNumber;

            decimal actual = calculator.Subtract(leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestSubtractingOnePositiveOneNegativeDecimalNumbers()
        {
            decimal leftNumber = 35.244M;
            decimal rightNumber = -25.32M;
            decimal expected = leftNumber - rightNumber;

            decimal actual = calculator.Subtract(leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestSubtractingTwoNegativeDecimalNumbers()
        {
            decimal leftNumber = -24.144M;
            decimal rightNumber = -25.332M;
            decimal expected = leftNumber - rightNumber;

            decimal actual = calculator.Subtract(leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void TestSubtractingDecimalsNumberByItself()
        {
            decimal leftNumber = 45.123M;
            decimal rightNumber = leftNumber;

            //expected should be 0
            decimal expected = 0;

            decimal actual = calculator.Subtract(leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestSubtractingNegativeDecimalsNumberByItself()
        {
            decimal leftNumber = -235.123M;
            decimal rightNumber = leftNumber;

            //expected should be 0
            decimal expected = 0;

            decimal actual = calculator.Subtract(leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestSubtractingTwoZeros()
        {
            decimal leftNumber = 0;
            decimal rightNumber = 0;

            //expected should be 0
            decimal expected = 0;

            decimal actual = calculator.Subtract(leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);

        }


        //=======MULTIPLICATION TESTS =========================

        [TestMethod]
        public void TestMultiplyingTwoPositiveNumbers()
        {
            decimal leftNumber = 25M;
            decimal rightNumber = 35M;
            decimal expected = leftNumber * rightNumber;

            decimal actual = calculator.Multiply(leftNumber, rightNumber );

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultiplyingOnePositiveOneNegativeNumbers()
        {
            decimal leftNumber = 15M;
            decimal rightNumber = -25M;
            decimal expected = leftNumber * rightNumber;

            decimal actual = calculator.Multiply(leftNumber, rightNumber );

            Assert.AreEqual(expected, actual);
        }

        //one of the property of multiplication is if you multiply number by 1 it should result in the same number
        [TestMethod]
        public void TestMultiplyingANumberByOneAndCheckIfResultIsSameNumber()
        {
            decimal leftNumber = 23M;
            decimal rightNumber = 1;

            //expected should be the leftNumber number itself
            decimal expected = leftNumber;

            decimal actual = calculator.Multiply(leftNumber, rightNumber );

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultiplyingOnePostiveOneNegativeNumbers()
        {
            decimal leftNumber = 25.09M;
            decimal rightNumber = -2.43M;
            decimal expected = leftNumber * rightNumber;

            decimal actual = calculator.Multiply(leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultiplyingTwoDecimalPositiveNumbers()
        {
            decimal leftNumber = 25.09M;
            decimal rightNumber = 1.43M;
            decimal expected = leftNumber * rightNumber;

            decimal actual = calculator.Multiply(leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultiplyingTwoDecimalNegativeNumbers()
        {
            decimal leftNumber = -15.09M;
            decimal rightNumber = -1.33M;
            decimal expected = leftNumber * rightNumber;

            decimal actual = calculator.Multiply(leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultiplyingOnePositiveOneNegativeDecimalNumbers()
        {
            decimal leftNumber = 12.09M;
            decimal rightNumber = -5.36M;
            decimal expected = leftNumber * rightNumber;

            decimal actual = calculator.Multiply(leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultiplyingAPostiveDecimalByOneAndCheckIfResultIsSameNumber()
        {
            decimal leftNumber = 23.2323M;
            decimal rightNumber = 1;

            //expected should be the leftNumber number itself
            decimal expected = leftNumber;

            decimal actual = calculator.Multiply(leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultiplyingANegativeDecimalByOneAndCheckIfResultIsSameNumber()
        {
            decimal leftNumber = -43.1267M;
            decimal rightNumber = 1;

            //expected should be the leftNumber number itself
            decimal expected = leftNumber;

            decimal actual = calculator.Multiply(leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultiplyingTwoZeros()
        {
            decimal leftNumber = 0M;
            decimal rightNumber = 0M;

            //expected should be the leftNumber number itself
            decimal expected = 0M;

            decimal actual = calculator.Multiply(leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);
        }


        //=======DIVISION TESTS =========================


        [TestMethod]
        public void TestDividingTwoNumbers()
        {
            decimal leftNumber = 24M;
            decimal rightNumber = -12M;
            decimal expected = leftNumber / rightNumber;

            decimal actual = calculator.Divide(leftNumber, rightNumber );

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDividingANumberByZero()
        {
            decimal leftNumber = 24M;
            decimal rightNumber = 0;

            Assert.ThrowsException<DivideByZeroException>(() => calculator.Divide(leftNumber,rightNumber));
        }

        //one of the property of division is if you divide number by 1 you get back the same number
        [TestMethod]
        public void TestDividingANumberByOne()
        {
            decimal leftNumber = 24.0M;
            decimal rightNumber = 1M;
            //expected should be the leftNumber number itself
            decimal expected = leftNumber;

            decimal actual = calculator.Divide(leftNumber, rightNumber );

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDividingTwoNegativeNumbers()
        {
            decimal leftNumber = -24M;
            decimal rightNumber = -12M;
            decimal expected = leftNumber / rightNumber;

            decimal actual = calculator.Divide(leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDividingTwoDecimalNumbers()
        {
            decimal leftNumber = 24.24M;
            decimal rightNumber = 12.12M;
            decimal expected = leftNumber / rightNumber;

            decimal actual = calculator.Divide(leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDividingTwoNegativeDecimalNumbers()
        {
            decimal leftNumber = -44.24M;
            decimal rightNumber = -22.12M;
            decimal expected = leftNumber / rightNumber;

            decimal actual = calculator.Divide(leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDividingOnePostiveOneNegativeDecimalNumbers()
        {
            decimal leftNumber = 24.24M;
            decimal rightNumber = -22.12M;
            decimal expected = leftNumber / rightNumber;

            decimal actual = calculator.Divide(leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDividingADecimalByOne()
        {
            decimal leftNumber = 24.1342M;
            decimal rightNumber = 1M;
            //expected should be the leftNumber number itself
            decimal expected = leftNumber;

            decimal actual = calculator.Divide(leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDividingANegativeDecimalByOne()
        {
            decimal leftNumber = -63.42M;
            decimal rightNumber = 1M;
            //expected should be the leftNumber number itself
            decimal expected = leftNumber;

            decimal actual = calculator.Divide(leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDividingTwoZeros()
        {
            decimal leftNumber = 0;
            decimal rightNumber = 0;

            Assert.ThrowsException<DivideByZeroException>(() => calculator.Divide(leftNumber, rightNumber));
        }


        //=======OPERATOR TESTS =========================

        [TestMethod]
        public void TestAddOperatorWithTwoDecimals()
        {
            decimal leftNumber = 63.42M;
            decimal rightNumber = 11.23M;
            string operator_code = "+";
            string result_format = "0.####";

            string expected = (leftNumber+rightNumber).ToString(result_format);

            string actual = calculator.OperatorSwitch(operator_code, leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSubtractOperatorWithTwoDecimals()
        {
            decimal leftNumber = 53.42M;
            decimal rightNumber = 92.23M;
            string operator_code = "-";
            string result_format = "0.####";

            string expected = (leftNumber - rightNumber).ToString(result_format);

            string actual = calculator.OperatorSwitch(operator_code, leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultiplyOperatorWithTwoDecimals()
        {
            decimal leftNumber = 6.42M;
            decimal rightNumber = 27.23M;
            string operator_code = "*";
            string result_format = "0.####";

            string expected = (leftNumber * rightNumber).ToString(result_format);

            string actual = calculator.OperatorSwitch(operator_code, leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDivisionOperatorWithTwoDecimals()
        {
            decimal leftNumber = 92.42M;
            decimal rightNumber = 23.23M;
            string operator_code = "/";
            string result_format = "0.####";

            string expected = (leftNumber / rightNumber).ToString(result_format);

            string actual = calculator.OperatorSwitch(operator_code, leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInvalidOperatorWithTwoDecimals()
        {
            decimal leftNumber = 92.42M;
            decimal rightNumber = 23.23M;
            string operator_code = "%";
            string result_format = "0.####";

            // if the operator is invlaid by default it is coded to performs addition
            string expected = (leftNumber + rightNumber).ToString(result_format);

            string actual = calculator.OperatorSwitch(operator_code, leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);
        }

    }
}
