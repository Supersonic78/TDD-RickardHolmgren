using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncNDelegates
{
    class Program
    {
        delegate double CalcDelegate(double a, double b);
        static void Main(string[] args)
        {
            List<Action> ListOfActions = new List<Action>();

            var order = new Order()
            {
                Name = "Widget A",
                Price = 3.14m,
                Quantity = 100,
                Paid = false
        };


    }
}
}
