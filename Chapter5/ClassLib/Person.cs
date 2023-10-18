using System;
using static System.Console;

namespace ClassLib
{
    public class Person : object
    {
        //ПОЛЯ
        public string? Name;
        public DateTime DateOfBirth;
        public List<Person> Children = new();

        //МЕТОДЫ
        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on {DateOfBirth:dd MMMM yyyy}.");
        }

        //СТАТИК МЕТОД КОТОРЫЙ ДЕЛАЕТ "РАЗМНОЖЕНИЕ" 
        public static Person Procreate(Person p1, Person p2)
        {
            Person baby = new()
            {
                Name = ($"Baby of {p1} and {p2}.")
            };
            
            p1.Children.Add(baby);
            p2.Children.Add(baby);

            return baby;
        }

        //МЕТОД ЭКСЗЕМПЛЯРЯ ДЛЯ "РАЗМНОЖЕНИЯ"
        public Person ProcreateWith(Person partner)
        {
            return Procreate(this, partner);
        }
    }
}