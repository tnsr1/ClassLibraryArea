using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryArea;

namespace ClassLibraryAreaTests
{
    [TestClass]
    public class Area�alculationTests
    {
        [TestMethod]
        public void CircleArea1_Pi()
        {
            double r = 1;
            double expected = Math.PI;
            //------------------
            Area�alculation l = new Area�alculation();
            double actual = l.CircleArea(r);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CircleArea2_Pi()
        {
            double r = 2;
            double expected = Math.PI * 4;
            //------------------
            Area�alculation l = new Area�alculation();
            double actual = l.CircleArea(r);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TriangleArea345_6()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;
            //------------------
            Area�alculation l = new Area�alculation();
            double actual = l.TriangleArea(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
