namespace Calculator
{
    public class LoggableCalculator : ICalculable
    {
        protected ICalculable calc;
        ILoggable calcLogger = new CalcLogger();

        public LoggableCalculator(ICalculable calc)
        {
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
            return calc.getResult();
        }

        public void saveToList(int arg)
        {
            calc.saveToList(arg);
        }

        public void printLogFile()
        {
            calc.printLogFile();
        }
    }
}
