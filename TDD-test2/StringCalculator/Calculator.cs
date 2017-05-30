using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class Calculator
    {
        public static int Add(string value)
        {
            if (value == "") return 0;
            var sum = 0;
            var delimiters = new List<char> { ',', '\n' };
            if (value.StartsWith("//"))
            {
                delimiters.Add(value[2]);
                value = value.Substring(4);
            }
            var values = new List<int>();
            Array.ForEach(value.Split(delimiters.ToArray()), s => values.Add (int.Parse(s)));

            values.ForEach(s => sum += s);
            return sum;
        }
    }
}
