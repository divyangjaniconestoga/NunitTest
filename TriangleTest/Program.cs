using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleConfirmation;

namespace TriangleTest
{
    [TestFixture]
    internal class Program
    {
        
        static void Main(string[] args)
        {
        }

        [Test]
        public void ValidTriangle_Input60and60and60_ExpectedValidTriangle()
        {
            int firstangle = 60;
            int secondangle = 60;
            int thirdangle = 60;

            string expected = "This triangle is valid.";
            string actual=Triangle.ValidTriangle(firstangle, secondangle, thirdangle);
            Assert.AreEqual(expected, actual);
        
        }
    }
}
