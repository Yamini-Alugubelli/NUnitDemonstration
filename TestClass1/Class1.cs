using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitDemonstration;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace TestClass1
{
    //SENG8041_YaminiAlugubeli_8991450_lab2
    public class Class1
    {
        public class TriangleTest2
        {
            [Test]
            public void ValidTraiangle_Input60and60and60_OutputValidTrialngle()
            {
                int firstAngle = 60;
                int secondAngle = 60;
                int thirdAngle = 60;

                String excepted = "The triangle is valid.";
                String actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                ClassicAssert.AreEqual(excepted, actual);
            }
        }
    }
}
