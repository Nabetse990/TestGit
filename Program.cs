using TestGit;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.WriteLine("Esto la verdad que es solo una prueba a ver como se hace para mergear y cosas asi...");

Human human = new Human
{
    Year = 1990,
    Month = 12,
    Day = 1,
    Name = "Esteban",
    HeightCms = 178,
    WeightKgs = 105
};


Hero hero = new Hero()
{
    Year = 1990,
    Month = 03,
    Day = 1,
    Name = "Arthur",
    HeightCms = 180,
    WeightKgs = 90,
    Weapon = "Fire Sword",
    Shield = "Iron Shield"
};

Enemy enemy = new Enemy()
{
    Year = 1990,
    Month = 1,
    Day = 1,
    Name = "Mortadela",
    HeightCms = 210,
    WeightKgs = 120,
    Weapon = "9mm",
    Armor = "Kevlar"

};

Console.WriteLine("Buenos dias, esta partida la gano el bueno, vamos capos!");