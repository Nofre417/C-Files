using static System.IO.Path;
using static System.IO.Directory;
using static System.Console;
using static System.Environment;
using System.IO;
using System;

namespace Calculator
{
    public interface IRepository
    {
        void saveToFile(List<string> list);
        void readFromFile();
    }
}
