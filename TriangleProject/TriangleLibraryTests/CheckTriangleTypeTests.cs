using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TriangleLibrary;

namespace TriangleLibraryTests
{
    [TestClass]
    public class CheckTriangleTypeTests
    {
        [TestMethod]
        public void IsTriangleExists_WhenItIsLine_ReturnNotTriangle()
        {
            // Arrange
            CheckTriangleType checkType = new CheckTriangleType(new Triangle(3, 2, 1));
            string expected = "Не треугольник";

            // Act
            string result = checkType.ToString();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsTriangleExists_WithUnrealSides_ReturnNotTriangle()
        {
            // Arrange
            CheckTriangleType checkType = new CheckTriangleType(new Triangle(4, 2, 1));
            string expected = "Не треугольник";

            // Act
            string result = checkType.ToString();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckTriangleType_EquilateralTriangle_ReturnEquilateralАcuteangled()
        {
            // Arrange
            CheckTriangleType checkType = new CheckTriangleType(new Triangle(3, 3, 3));
            string expected = "Равносторонний\nОстроугольный";

            // Act
            string result = checkType.ToString();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckTriangleType_IsoscelesАcuteangledTriangle_ReturnIsoscelesАcuteangled()
        {
            // Arrange
            CheckTriangleType checkType = new CheckTriangleType(new Triangle(3, 3, 2));
            string expected = "Равнобедренный\nОстроугольный";

            // Act
            string result = checkType.ToString();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckTriangleType_IsoscelesObtuseTriangle_ReturnIsoscelesObtuse()
        {
            // Arrange
            CheckTriangleType checkType = new CheckTriangleType(new Triangle(1, 1, 1.7));
            string expected = "Равнобедренный\nТупоугольный";

            // Act
            string result = checkType.ToString();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckTriangleType_ScaleneАcuteangledTriangle_ReturnScaleneАcuteangled()
        {
            // Arrange
            CheckTriangleType checkType = new CheckTriangleType(new Triangle(2, 2.5, 2.7));
            string expected = "Разносторонний\nОстроугольный";

            // Act
            string result = checkType.ToString();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckTriangleType_ScaleneRectangularTriangle_ReturnScaleneRectangular()
        {
            // Arrange
            CheckTriangleType checkType = new CheckTriangleType(new Triangle(3, 5, 4));
            string expected = "Разносторонний\nПрямоугольный";

            // Act
            string result = checkType.ToString();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckTriangleType_ScaleneObtuseTriangle_ReturnScaleneObtuse()
        {
            // Arrange
            CheckTriangleType checkType = new CheckTriangleType(new Triangle(2, 5, 6.5));
            string expected = "Разносторонний\nТупоугольный";

            // Act
            string result = checkType.ToString();

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}