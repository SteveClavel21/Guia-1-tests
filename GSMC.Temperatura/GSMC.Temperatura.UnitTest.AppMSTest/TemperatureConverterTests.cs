using Microsoft.VisualStudio.TestTools.UnitTesting;
using GSMC.Temperatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMC.Temperatura.Tests
{
    [TestClass()]
    public class TemperatureConverterTests
    {
        [TestMethod()]
        public void CelsiusToFahrenheitTest()
        {
            // Arrange
            double celsius = 0;
            double expectedFahrenheit = 32;
            var converter = new TemperatureConverter(); // Asegúrate de que esta clase esté disponible

            // Act
            double actualFahrenheit = converter.CelsiusToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(expectedFahrenheit, actualFahrenheit);
        }

        [TestMethod()]
        public void FahrenheitToCelsiusTest()
        {
            // Arrange
            double fahrenheit = 32;
            double expectedCelsius = 0;
            var converter = new TemperatureConverter(); // Asegúrate de que esta clase esté disponible

            // Act
            double actualCelsius = converter.FahrenheitToCelsius(fahrenheit);

            // Assert
            Assert.AreEqual(expectedCelsius, actualCelsius);
        }
    }
}
