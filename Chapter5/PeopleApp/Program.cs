using System;
using static System.Console;
using System.Collections.Generic;
using MyLib;
using MyLibModern;

Clear();


//DAVID MOVAS
Person david = new();
david.Name = "David Movas";
david.DateTimeBirth = new DateTime(2002, 9, 23);
david.FavoritePlase = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
david.Children = new();
david.Children.Add(new Person { Name = "Alfred Movas"});
david.Children.Add(new Person { Name = "Luisa Movas" });


WriteLine($"{david.Name} is a {Person.Speciel}");
WriteLine(format: "{0} was born on {1:d M yyyy}", arg0: david.Name, arg1: david.DateTimeBirth);
WriteLine(format: "{0}'s favorite plase is {1}", arg0: david.Name, arg1: david.FavoritePlase);
WriteLine(format: "{0} have children:", arg0: david.Name);
for(int chilIndex = 0; chilIndex < david.Children.Count; chilIndex++)
{
    WriteLine($"{david.Children[chilIndex].Name}");
}
PrintSpliter();

//BANK_ACCOUNT
BankAccount.InterestRate = 0.012M;

BankAccount davidAccount = new(inputName: "David Movas", balance: 1_736_883.25M);

WriteLine($"{davidAccount.AccountName} was registred in {davidAccount.BankName}");
WriteLine(format: "Balance: {0:N}$", arg0: davidAccount.Balance);
WriteLine(format: "{0} have to pay {1:N}$ for service.", arg0: davidAccount.AccountName, arg1: davidAccount.Balance * BankAccount.InterestRate);

PrintSpliter();

BankAccount blanckBankAccount = new(inputName: "Lu Makoy", balance: 345_855.4M);

WriteLine(format: "{0} was created at {1:hh:mm:ss} on {1:dd MMMM yyyy}\nBalance: {2}$", arg0: blanckBankAccount.AccountName, arg1: blanckBankAccount.Instantiated, arg2: blanckBankAccount.Balance);

PrintSpliter();

//TOUPLE
var fruit = david.GetFruit();

WriteLine($"David have {fruit.Number} {fruit.Name}");

PrintSpliter();

// 1 AND 2 TOUPLE
var touple1 = ("Age", 20);
WriteLine($"{touple1.Item1} is {touple1.Item2}");

var touple2 = (david.Name, david.Children.Count);
WriteLine($"{touple2.Name} has {touple2.Count} children");

PrintSpliter();

//DECONSTRUCTION 
(string name, int number) = david.GetFruit();

WriteLine($"Deconstructed touple: \nName: {name} \nNubmer: {number}");

PrintSpliter();

//DECONSTUCT DAVID
var (name1, dob1) = david;
WriteLine($"Deconstructed: {name1} {dob1:D}");

var (name2, dob2, fav2) = david;
WriteLine($"Deconstructed: {name2} {dob2:D} {fav2}");

PrintSpliter();

//HELLOY METHODS
WriteLine(david.SayHelloy());
WriteLine(david.SayHelloy("Emili"));

PrintSpliter();

//OPTIONAL METHOD'S PARAMETERS
WriteLine(david.OptionalParameters());
WriteLine(david.OptionalParameters("Jump", 128.4M));
WriteLine(david.OptionalParameters(number: 57.3M, command: "Hide"));
WriteLine(david.OptionalParameters(command: "Poke", active: false));

PrintSpliter();

//PASSING_PARAMETERS_1
int a = 10, b = 20, c = 30;
WriteLine($"Before: a = {a}, b = {b}, c = {c}");
david.PassingParameters(a, ref b, out c);
WriteLine($"After: a = {a}, b = {b}, c = {c}");
WriteLine();
int d = 10, e = 20;
WriteLine($"Before: d = {d}, e = {e}, f doesn't exist yet !");
david.PassingParameters(d, ref e, out int f);
WriteLine($"After: d = {d}, e = {e}, f = {f}");

PrintSpliter();

//СВОЙСТВА 
//SAM
Person sam = new() { Name = "Sam Muller", DateTimeBirth = new(1998, 9, 10)};

WriteLine(sam.Greeting);
WriteLine(sam.Origin);
WriteLine(sam.Age);

//SAM_INFO
sam.FavoriteCar = "BMW";
WriteLine($"{sam.Name}'s favorite car: {sam.FavoriteCar}");
sam.FavoritePrimaryColor = "Orange";
WriteLine($"{sam.Name}'s favorite color: {sam.FavoritePrimaryColor}");

//SAM_INDEXED_CHILDREN
sam.Children = new();
sam.Children.Add(new() { Name = "Jake Muller" });
sam.Children.Add(new() { Name = "Anite Muller" });

WriteLine($"{sam.Name}'s first children is {sam.Children[0].Name}");
WriteLine($"{sam.Name}'s second children is {sam.Children[1].Name}");

ReadLine();

static void PrintSpliter()
{
    Person person = new();
    person.PrintSpliter();
}