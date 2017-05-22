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
        public void ValidateEmailAddress(string email)
        {
            ValidMail = Regex.IsMatch(email, emailRegex);
        }
    }
}
