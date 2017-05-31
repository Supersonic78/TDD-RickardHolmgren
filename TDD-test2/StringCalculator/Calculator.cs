using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class Calculator
    {
        private List<char> delimiters = new List<char> { ',', '\n' };
        public int Add(string value)
        {
            if (value == "") return 0;
            var sum = 0;

            parseForValues(parseForDelimiter(value))
                .ForEach(s => sum += s);
            //value = parseForDelimiter(value);
            //List<int> values = parseForValues(value);
         
            return sum;
        }

        private List<int> parseForValues(string value)
        {
            var values = new List<int>();
            Array.ForEach(value.Split(delimiters.ToArray()), s =>
            {
                var number = int.Parse(s);
                if (number < 0) throw new Exception("Negatives are not allowed");
                values.Add(number);
            });
            
            return values;
        }

        private string parseForDelimiter(string value)
        {
            if (value.StartsWith("//"))
            {
                delimiters.Add(value[2]);
                value = value.Substring(4);
            }
            return value;
        }
    }
}
