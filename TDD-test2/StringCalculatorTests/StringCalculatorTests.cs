using NUnit.Framework;
using StringCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorTests
{
    [TestFixture]
    public class StringCalculatorTests
    {
        public Calculator sut { get; set; }
        [SetUp]
        public void Setup()
        {
            sut = new Calculator();
        }

        [Test]
        public void AddEmptyStringReturnZero()
        {
            var result = sut.Add("");
            Assert.AreEqual(0, result);
        }
        [Test]
        public void AddOneNumberReturnsNumber()
        {
            var result = sut.Add("1");
            Assert.AreEqual(1, result);
        }
        [Test]
        public void Add_TwoNumbersSeparatedByDelimiter_ReturnsSum()
        {
            var result = sut.Add("1,2");
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Add_MultipleNumbersSeparatedByDelimiter_ReturnsSum()
        {
            var result = sut.Add("1,2,3,4");
            Assert.AreEqual(10, result);
        }
        [Test]
        public void SplittNumbersOnNewLine()
        {    
            var result = sut.Add("1\n2,3");
            Assert.AreEqual(6, result);
        }
       
        [Test]
        public void AddNegativeNumbers_CastExeption()
        {
            TestDelegate add = () => sut.Add("-1");
            Assert.Throws<Exception>(add);
        }
    }
}
