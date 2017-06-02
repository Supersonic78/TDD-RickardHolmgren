using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Validator
{
    public class Validator
    {
        public bool ValidMail { get; set; }
        const string emailRegex = @"^([a-zA-Z]+)@([a-zA-Z]+).([a-zA-Z]+)$";
        public bool ValidateEmailAddress(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new Exceptions.NullOrEmptyExeption();
            }
            ValidMail = Regex.IsMatch(email, emailRegex);
            return ValidMail;
        }
    }
}
