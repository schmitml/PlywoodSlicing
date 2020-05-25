using System.Collections.Generic;
using NUnit.Framework;

namespace PlywoodSlicer.Tests
{
    public class RectangleTests
    {
        private IShape sut;
        public RectangleTests()
        {

        }

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void SimpleRectangle_HasDimensions()
        {
            sut = new Rectangle(10, 15);

            Assert.AreEqual(10, sut.Width);
            Assert.AreEqual(15, sut.Height);
        }

        [Test]
        public void SimpleRectangle_CalculateArea(){
            sut = new Rectangle(5, 5);

            Assert.AreEqual(25, sut.Area());
        }
    }
}