using static System.Console;

namespace WothWithEFCore
{
    public class Services
    {
        public void PrintProvaider()
        {
            WriteLine($"Using {ProjectConstants.DataBaseProvider} database provaider.");
        }

        public void Finish()
        {
            ForegroundColor = ConsoleColor.Yellow;
            Write("Press ENTER to finish:");
            ReadLine();
            ForegroundColor = ConsoleColor.White;
        }

        public void ClearConsole()
        {
            Clear();
        }

        public void StarProgram()
        {
            Clear();
            WriteLine("================================");
            WriteLine("START PROGRAM");
            WriteLine("================================");
        }
    }
}