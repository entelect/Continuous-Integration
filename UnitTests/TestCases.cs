using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class TestCases
    {
        [Test]
        public void TestSomething()
        {
            Assert.That(true, Is.True);
        }
    }
}
