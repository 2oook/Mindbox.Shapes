namespace Mindbox.Shapes.Tests
{
    using Mindbox.Shapes.Exceptions;
    using Mindbox.Shapes.Models;

    using NUnit.Framework;
    using System;

    public class ShapesTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Circle_CalculateSquare_ShouldReturnCorrectValue()
        {
            var result = new Circle(2).CalculateSquare();
            Assert.True(Math.Truncate(result * 100000) / 100000  == 12.56637);
        }

        [Test]
        public void Circle_Ctor_Should_ThrowArgumentOutOfRangeException_WhenRadiusIsNegative()
        {
            try
            {
                new Circle(-1);
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.Pass();
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Rectangle_CalculateSquare_ShouldReturnCorrectValue()
        {
            var result = new Triangle(2, 3.34, 5.007).CalculateSquare();
            Assert.True(Math.Truncate(result * 100000) / 100000 == 2.23876);
        }

        [Test]
        public void Rectangle_IsRight_ShouldReturnCorrectValue()
        {
            Assert.True(new Triangle(3, 4, 5).IsRight());
            Assert.True(new Triangle(3, 5, 4).IsRight());
            Assert.True(new Triangle(4, 3, 5).IsRight());
            Assert.True(new Triangle(4, 5, 3).IsRight());
            Assert.True(new Triangle(5, 3, 4).IsRight());
            Assert.True(new Triangle(5, 4, 3).IsRight());
        }

        [Test]
        public void Rectangle_IsRight_ShouldReturnIncorrectValue()
        {
            Assert.False(new Triangle(3, 5, 5).IsRight());
        }

        [Test]
        public void Rectangle_Ctor_Should_ThrowArgumentOutOfRangeException_WhenOneOfSidesIsNegative()
        {
            try
            {
                new Triangle(2, -3.34, -8.984);
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.Pass();
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Rectangle_CalculateSquare_Should_ThrowArgumentOutOfRangeException_WhenOneOfSidesLessThenSemiperimeter()
        {
            try
            {
                new Triangle(2, 3.34, 8.984).CalculateSquare();
                Assert.Fail();
            }
            catch (ThereIsNoSuchRectangleException)
            {
                Assert.Pass();
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
    }
}