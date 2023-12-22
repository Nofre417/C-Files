using static System.Console;

namespace Calculator
{
    public class CalcLogger : ILoggable
    {
        public void saveLog(string log)
        {
            ForegroundColor =  ConsoleColor.Red;
            WriteLine($"Log list: {log}");
            ForegroundColor = ConsoleColor.White;
        }
    }
}
