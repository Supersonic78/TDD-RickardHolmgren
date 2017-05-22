using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validator.test
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void TrueForValidAddress()
        {
            Validator sut = new Validator();
            sut.ValidateEmailAddress("Name2015@test.com");
            Assert.IsTrue(sut.ValidMail);
        }
        [Test]
        public void TrueForNotValidAddress()
        {
            Validator sut = new Validator();
            sut.ValidateEmailAddress("Name2015@test.com");
            Assert.IsFalse(sut.ValidMail);
        }

    }
}
