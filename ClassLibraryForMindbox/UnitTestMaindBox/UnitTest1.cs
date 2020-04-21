using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryForMindbox;

namespace UnitTestMaindBox
{
    [TestClass]
    public class UnitTest1
    {
        
 [TestMethod]
        public void TestAreaCalculation()
        {
            Assert.AreEqual(Areas.AreaCalculation(1, 4, 5, 8, 2), "Unknown figure");
            Assert.AreEqual(Areas.AreaCalculation(13, 12, 5), "Triangle, S=30, IsRightTriangle=True");
            Assert.AreEqual(Areas.AreaCalculation(5, 6, 2.2), "Triangle, S=5,28, IsRightTriangle=False");
            Assert.AreEqual(Areas.AreaCalculation(6, 8, 10), "Triangle, S=24, IsRightTriangle=True");
            Assert.AreEqual(Areas.AreaCalculation(1), "Circle, S=" + Math.PI);
            Assert.AreEqual(Areas.AreaCalculation(), "Unknown figure");
        }
    
    }
}
