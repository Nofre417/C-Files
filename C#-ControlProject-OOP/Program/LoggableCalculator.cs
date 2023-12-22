using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class LoggableCalculator : ICalculable
    {
        protected ICalculable calc;

        Repository repository = new Repository();
        ILoggable calcLogger = new CalcLogger();


        public LoggableCalculator(ICalculable calc)
        {
            repository.createLogFile();
            calcLogger.saveLog("" + calc.getResult());
            this.calc = calc;
        }


        public ICalculable sum(int arg)
        {
            calcLogger.saveLog(calc.getResult() + " + " + arg);
            return calc.sum(arg);
        }

        public ICalculable multiply(int arg)
            {
                calcLogger.saveLog(calc.getResult() + " * " + arg);
                return calc.multiply(arg);
            }

        public ICalculable divide(int arg)
            {
                calcLogger.saveLog(calc.getResult() + " / " + arg);
                return calc.divide(arg);
            }
        public int getResult()
        {
            int result = calc.getResult();
            calcLogger.saveLog("= " + result);
            repository.saveToFile(Convert.ToString(result));
            return calc.getResult();
        }
    }
}
