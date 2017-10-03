using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SampleTravisCI;

namespace Calculator.Test
{
    [TestFixture]
    public class Cal_Test
    {
        private SampleTravisCI.Calculator _Calculator;
        [SetUp]
        public void Setup()
        {
            _Calculator = new SampleTravisCI.Calculator();
        }
        [Test]
        public void OnePlusOne()
        {
            Assert.AreEqual(2, _Calculator.Add(1, 1));
        }
        [Test]
        public void ThreeSubTwo()
        {
            Assert.AreEqual(1, _Calculator.Subtract(3, 2));
        }
    }
}
