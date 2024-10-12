using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using Xunit;
using GSMCManipulator;

namespace GSMCManipulator.UnitTest.AppxUnit
{
    public class StringManipulatorTests
    {

        [Fact]
        public void ReverseString_ShouldReturnReversedString()
        {
            // Arrange
            StringManipulator manipulator = new StringManipulator();
            string input = "Hello";
            string expected = "olleH";

            // Act
            string result = manipulator.ReverseString(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void RemoveSpaces_ShouldRemoveAllSpaces()
        {
            // Arrange
            StringManipulator manipulator = new StringManipulator();
            string input = "H e l l o";
            string expected = "Hello";

            // Act
            string result = manipulator.RemoveSpaces(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ReverseString_EmptyString_ShouldReturnEmptyString()
        {
            // Arrange
            StringManipulator manipulator = new StringManipulator();
            string input = "";
            string expected = "";

            // Act
            string result = manipulator.ReverseString(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void RemoveSpaces_EmptyString_ShouldReturnEmptyString()
        {
            // Arrange
            StringManipulator manipulator = new StringManipulator();
            string input = "";
            string expected = "";

            // Act
            string result = manipulator.RemoveSpaces(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ReverseString_NullInput_ShouldReturnNull()
        {
            // Arrange
            StringManipulator manipulator = new StringManipulator();
            string input = null;

            // Act
            string result = manipulator.ReverseString(input);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void RemoveSpaces_NullInput_ShouldReturnNull()
        {
            // Arrange
            StringManipulator manipulator = new StringManipulator();
            string input = null;

            // Act
            string result = manipulator.RemoveSpaces(input);

            // Assert
            Assert.Null(result);
        }
    }
}
