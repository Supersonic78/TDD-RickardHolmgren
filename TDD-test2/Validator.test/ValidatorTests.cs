using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validator;

namespace Validator.test
{
    [TestFixture]
    public class ValidatorTests
    {
        [Test]
        public void TrueForValidAddress()
        {
            Validator sut = new Validator();
            var result = sut.ValidateEmailAddress("Name@test.com");
            Assert.IsTrue(result);
        }


        [Test]
        public void TrueForNotValidAddress()
        {
            Validator sut = new Validator();
            sut.ValidateEmailAddress("Name2015@test.com");
            Assert.IsFalse(sut.ValidMail);
        }


        [Test]
        public void NullOrEmptyExceptionForNullOrEmpty()
        {
            Validator sut = new Validator();

            Assert.Throws<Exceptions.NullOrEmptyExeption>(() =>
            {
                sut.ValidateEmailAddress(null);
            });

        }

    }
}
