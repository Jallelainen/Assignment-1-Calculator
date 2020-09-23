using System;
using Xunit;

namespace Calculator.test
{
    public class calculatortest
    {
        [Fact]
        public void TestAddition()
        {
            //Arrange
            double number1 = 1;
            double number2 = 2;
            double expected = 3;

            //Act
            double actual = Calculator.Program.Add(number1, number2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void TestDivision()
        {
            //Arrange
            double number1 = 1;
            double number2 = 3;
            double expected = 0.333;

            //Act
            double actual = Calculator.Program.Div(number1, number2);

            //Assert
            Assert.Equal(expected, actual, 3); //3 = precision delta. 

        }

        [Fact]
        public void TestSub()
        {
            //Arrange
            double number1 = 4;
            double number2 = 2;
            double expected = 2;

            //Act
            double actual = Calculator.Program.Sub(number1, number2);

            //Assert
            Assert.Equal(expected, actual); 

        }

        [Fact]
        public void TestMul()
        {
            //Arrange
            double number1 = 3;
            double number2 = 3;
            double expected = 9;

            //Act
            double actual = Calculator.Program.Mul(number1, number2);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
