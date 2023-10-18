using System;
using static System.Console;
using System.Collections.Generic;
using MyLib;
using MyLibModern;
using System.Runtime.ConstrainedExecution;

PrintSpliter(color: ConsoleColor.Green, newLineBoth: false);

//СОЗДАЕМ МАССИВ ОБЪЕКТОВ (КЛАССОВ)
object[] passangers =
{
    new BusinessClassPassanger(),
    new FirstClassPassanger{ AirMiles = 1_458},
    new FirstClassPassanger{ AirMiles = 41_744},
    new FirstClassPassanger{ AirMiles = 8_438},
    new FirstClassPassanger{ AirMiles = 16_346},
    new CoachClassPassanger{ CarryOnKG = 12.5},
    new CoachClassPassanger{ CarryOnKG = 7.37},
    new CoachClassPassanger{ CarryOnKG = 21.1},
    new CoachClassPassanger{ CarryOnKG = 14.89},
    new CoachClassPassanger{ CarryOnKG = 18.3},
    new CoachClassPassanger{ CarryOnKG = 3.89},

};

//ЧЕРЕЗ ОПЕРАТОРЫ ПРИСВАЕВАЕМ ЗНАЧЕНИЯ ОБЪЕКТАМ (FOREACH/W|SWITCH)
foreach (object passanger in passangers)
{
    decimal flightCost = passanger switch
    {
        BusinessClassPassanger => 2300M,
        /*
        FirstClassPassanger p when p.AirMiles > 20000 => 1500M,
        FirstClassPassanger p when p.AirMiles > 10000 => 1800M,
        FirstClassPassanger _ => 2000M,
        */
        FirstClassPassanger p => p.AirMiles switch
        {
            > 20000 => 1500M,
            > 10000 => 1800M,
            _       => 2000M,
        },
        CoachClassPassanger p => p.CarryOnKG switch
        {
            > 20 => 1000,
            > 14 => 900,
            > 10 => 850,
            _    => 700,
        },
    }; 

    WriteLine($"Ticket price for {passanger} is {flightCost}$");
}

PrintSpliter(color: ConsoleColor.Green, newLineBoth: false);

//СОЗДАЛИ ОБЪЕКТ ТОЛЬКО ДЛЯ ЗАПИСИ (ИЗМЕНИТЬ НЕЛЬЗЯ )
ImmutablePerson jeff = new()
{
    FirstName = "Jeff",
    LastName = "Stivens",
};

//jeff.FirstName = "Movas";

//НЕДЕСТРУКТИВНАЯ МУТАЦИЯ
ImmutableVehicle car = new()
{
    Wheels = 4,
    Color = "Orange",
    Brand = "BMW M5 2020 Competion",
};
//МЫ НЕ МОЖЕМ ИЗМЕНИТЬ ОБЪЕКТ CAR НО МОЖЕМ СОЗДАТЬ КОПИЮ И ИЗМЕНИТЬ ЕЕ ПРИ СОЗДАНИИ
ImmutableVehicle newCar = car
    with{ Brand = "BMW M5 2021 Competion" };

WriteLine($"Original  BMW 2020 => {car.Brand}");
WriteLine($"Restailed BMW 2021 => {newCar.Brand}");

PrintSpliter(color: ConsoleColor.Magenta, newLineBoth: false, newLine2: true);

//ВМЕСТО ТОГО ЧТОБ УКАЗВАТЬ (GET/SET/INIT) В СВОЙСТВЕ (RECORD) МЫ МОЖЕМ ПОЗВОЛИТЬ ДЕЛАТЬ ЭТО КОМПИЛЯТОРУ
ImmutableRaseTeam team = new("RedBull", 38_750_400.00M);
var (teamName, teamBudget) = team;
WriteLine($"{teamName} has {teamBudget:N2}$ for this year");

PrintSpliter(color: ConsoleColor.Magenta, newLineBoth: false, newLine1: true);

ReadLine();

//МЕТОД ДЛЯ ВЫВОДА СПЛИТЕРА КОТОРЫЙ МОЖНО КОТРОЛИРОВАТЬ
static void PrintSpliter(ConsoleColor color = ConsoleColor.White, bool newLineBoth = true, bool newLine1 = false, bool newLine2 = false)
{
    if (newLine1 || newLineBoth) WriteLine();
    ForegroundColor = color;
    WriteLine("============================================================");
    ForegroundColor = ConsoleColor.White;
    if (newLine2 || newLineBoth) WriteLine();
}