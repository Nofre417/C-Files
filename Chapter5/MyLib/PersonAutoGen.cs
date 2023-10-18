using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public partial class Person
    {
        //Свойство GET
        public string Origin
        {
            get
            {
                return ($"{Name} was born on {DateTimeBirth:dd MMMM yyyy}");
            }
        }

        public string Greeting => ($"{Name} says helloy !");
        public string Age => ($"{Name} age is {DateTime.Now.Year - DateTimeBirth.Year}");

        public string FavoriteCar { get; set; }

        private string favoritePrimaryColor;

        public string FavoritePrimaryColor
        {
            get
            {
                return favoritePrimaryColor;
            }
            set
            {
                switch(value.ToLower())
                {
                    case "red":
                    case "blue":
                    case "orange":
                        favoritePrimaryColor = value;
                        break;
                    default:
                        throw new System.ArgumentException($"{value} is not primary colot.\nChoose from: red, blue, orange");
                }
            }
        }

        public Person this[int index]
        {
            get { return Children[index]; }
            set { Children[index] = value; }
        }

    }
}
