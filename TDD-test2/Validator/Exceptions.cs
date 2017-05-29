using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validator
{
   public class Exceptions
    {
        public class NotValidEmailException : Exception
        {
            public NotValidEmailException()
            {

            }
            public NotValidEmailException(string message) : base(message)
            {

            }
        }
        public class NullOrEmptyExeption : Exception
        {

        }
    }
}
