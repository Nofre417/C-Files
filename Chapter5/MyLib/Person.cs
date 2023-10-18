using System;
using static System.Console;
using MyLib;
namespace MyLib
{

    public partial class  Person : System.Object
    {
        public string Name;
        public DateTime DateTimeBirth;
        public List<Person> Children;
        public WondersOfTheAncientWorld FavoritePlase;

        public const string Speciel = "Human";

        public (string Name, int Number) GetFruit()
        {
            return (Name: "Apple", Number: 15);
        }

        public void Deconstruct(out string name, out DateTime dob)
        {
            name = Name;
            dob = DateTimeBirth;
        }

        public void Deconstruct(out string name, out DateTime dob, out WondersOfTheAncientWorld fav)
        {
            name = Name;
            dob = DateTimeBirth;
            fav = FavoritePlase;
        }

        public string SayHelloy()
        {
            return ($"Hellot dear {Name}");
        }

        public string SayHelloy(string name)
        {
            return ($"{Name} says Helloy to {name}");
        }

        public string OptionalParameters(string command = "Run", decimal number = 0.0M, bool active = true)
        {
            return string.Format(format: "Command is {0}, number is {1}, active is {2}", arg0: command, arg1: number, arg2: active);
        }

        public void PassingParameters(int x, ref int y, out int z)
        {
            z = 99;
            x++;
            y++;
            z++;
        }
        public void PrintSpliter()
        {
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("\n=========================================================\n");
            ForegroundColor = ConsoleColor.White;
        }
    }

    

    
}