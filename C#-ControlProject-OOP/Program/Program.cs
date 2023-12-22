using static System.Console;
using System.IO;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICalculableFactory calculableFactory = new CalculableFactory();
            ViewCalculator view = new ViewCalculator(calculableFactory);
            view.Run();
        }
    }
}
