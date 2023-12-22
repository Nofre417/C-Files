using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calculator
{
    public class CalculableFactory : ICalculableFactory
    {
        public ICalculable create(int primaryArg, bool logFlag)
        {
            if (logFlag)
            {
                ICalculable calculator = new Calculator(primaryArg);
                return new LoggableCalculator(calculator);
            }
            return new Calculator(primaryArg);
        }

    }
}
