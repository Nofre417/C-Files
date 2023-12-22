

namespace Calculator
{
    public interface ICalculable
    {
        ICalculable sum(int arg);
        ICalculable multiply(int arg);
        ICalculable divide(int arg);

        int getResult();
    }
}
