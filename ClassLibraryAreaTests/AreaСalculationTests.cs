using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryArea;

namespace ClassLibraryAreaTests
{
    [TestClass]
    public class AreaŅalculationTests
    {
        [TestMethod]
        public void CircleArea1_Pi()
        {
            double r = 1;
            double expected = Math.PI;
            //------------------
            AreaŅalculation l = new AreaŅalculation();
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
            AreaŅalculation l = new AreaŅalculation();
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
            AreaŅalculation l = new AreaŅalculation();
            double actual = l.TriangleArea(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
