using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment3M;
using NUnit.Framework;

namespace CalculationTest
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void GetAddition_Input10andInput80_Returns100()
        {

            //Arrange
            double number1 = 10;
            double number2 = 80;

            double expectedResult = number1 + number2;

            Calculation testCalc = new Calculation(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
             [Test]
        public void GetAddition_Input1point5andInput8point3_Returns9point8()
        {

            //Arrange
            double number1 = 1.5;
            double number2 = 8.3;

            double expectedResult = number1 + number2;

            Calculation testCalc = new Calculation(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetAddition_Inputminus5andInputminus3_Returnsminus7()
        {

            //Arrange
            double number1 = -5;
            double number2 = -2;

            double expectedResult = number1 + number2;

            Calculation testCalc = new Calculation(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetSubtraction_Input88andInput2_Returns86()
        {

            //Arrange
            double number1 = 88;
            double number2 = 2;

            double expectedResult = number1 - number2;

            Calculation testCalc = new Calculation(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetSubtraction_Input199andInput2_Returns197()
        {

            //Arrange
            double number1 = 199;
            double number2 = 2;

            double expectedResult = number1 - number2;

            Calculation testCalc = new Calculation(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetSubtraction_Inputminus33andInput9_Returnsminus24()
        {

            //Arrange
            double number1 = -33;
            double number2 = 9;

            double expectedResult = number1 - number2;

            Calculation testCalc = new Calculation(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetMultiplication_Input9andInput2_Returns18()
        {

            //Arrange
            double number1 = 9;
            double number2 = 2;

            double expectedResult = number1 * number2;

            Calculation testCalc = new Calculation(number1, number2);

            //Act
            double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetMultiplication_Input14point5andInput4_Returns58()
        {

            //Arrange
            double number1 = 14.5;
            double number2 = 4;

            double expectedResult = number1 * number2;

            Calculation testCalc = new Calculation(number1, number2);

            //Act
            double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetMultiplication_Inputminus60andInputminus12_Returns720()
        {

            //Arrange
            double number1 = -60;
            double number2 = -12;

            double expectedResult = number1 * number2;

            Calculation testCalc = new Calculation(number1, number2);

            //Act
            double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetDivision_Input4andInput2_Returns2()
        {

            //Arrange
            double number1 = 4;
            double number2 = 2;

            double expectedResult = number1 / number2;

            Calculation testCalc = new Calculation(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetDivision_Input44andInput11_Returns4()
        {

            //Arrange
            double number1 = 44;
            double number2 = 11;

            double expectedResult = number1 / number2;

            Calculation testCalc = new Calculation(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetDivision_Input99andInput3_Returns33()
        {

            //Arrange
            double number1 = 99;
            double number2 = 3;

            double expectedResult = number1 / number2;

            Calculation testCalc = new Calculation(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

    }
}
