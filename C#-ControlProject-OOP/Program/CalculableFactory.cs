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
