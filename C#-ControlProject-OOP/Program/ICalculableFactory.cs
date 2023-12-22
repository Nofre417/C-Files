namespace Calculator
{
    public interface ICalculableFactory
    {
        ICalculable create(int primaryArg, bool logFlag);
    }
}
