using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UnitTest
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void test()
        {
            Assert.That(1, Is.EqualTo(1));
        }
    }
}
