using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator : ICalculable
    {
        private int primaryArg;

        public Calculator(int primaryArg)
        {
            this.primaryArg = primaryArg;
        }

        public ICalculable divide(int arg)
        {
            primaryArg /= arg;
            return this;
        }

        

        public ICalculable multiply(int arg)
        {
            primaryArg *= arg;
            return this;
        }

        public ICalculable sum(int arg)
        {
            primaryArg += arg;
            return this;
        }

        public int getResult()
        {
            return primaryArg;
        }
    }
}
