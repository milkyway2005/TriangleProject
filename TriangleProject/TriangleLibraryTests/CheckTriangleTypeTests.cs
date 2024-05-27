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
            string expected = "�� �����������";

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
            string expected = "�� �����������";

            // Act
            string result = checkType.ToString();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckTriangleType_EquilateralTriangle_ReturnEquilateral�cuteangled()
        {
            // Arrange
            CheckTriangleType checkType = new CheckTriangleType(new Triangle(3, 3, 3));
            string expected = "��������������\n�������������";

            // Act
            string result = checkType.ToString();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckTriangleType_Isosceles�cuteangledTriangle_ReturnIsosceles�cuteangled()
        {
            // Arrange
            CheckTriangleType checkType = new CheckTriangleType(new Triangle(3, 3, 2));
            string expected = "��������������\n�������������";

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
            string expected = "��������������\n������������";

            // Act
            string result = checkType.ToString();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckTriangleType_Scalene�cuteangledTriangle_ReturnScalene�cuteangled()
        {
            // Arrange
            CheckTriangleType checkType = new CheckTriangleType(new Triangle(2, 2.5, 2.7));
            string expected = "��������������\n�������������";

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
            string expected = "��������������\n�������������";

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
            string expected = "��������������\n������������";

            // Act
            string result = checkType.ToString();

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}