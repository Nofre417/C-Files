using System;
using static System.Console;
using System.Collections.Generic;
using ClassLib;

Clear();

//CREATED PERSONS AND BABYS
Person harry = new() { Name = "Harry" };
Person emily = new() { Name = "Emily" };
Person vika = new() { Name = "Vika" };

Person baby1 = emily.ProcreateWith(harry);
baby1.Name = "Jake";

Person baby2 = Person.Procreate(harry, vika);
baby2.Name = "Nicolas";

//OUTPUT
WriteLine($"Harry has {harry.Children.Count} children: {baby1.Name}, {baby2.Name}.");
WriteLine(format: "{0}'s first children is named: {1}", arg0: harry.Name, arg1: harry.Children[0].Name);
WriteLine($"Emile has {emily.Children.Count} children: {baby1.Name}");
WriteLine($"Vika has {vika.Children.Count} children: {baby2.Name}");































ReadLine();