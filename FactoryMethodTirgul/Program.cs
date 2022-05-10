using FactoryMethodTirgul;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
// calculate the Ibm of the sportsman
Console.WriteLine("Please Enter your weight and height");
double weight = double.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());
Dietician dietician = new Dietician();
DietBase diet = dietician.GetDiett(weight, height);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("The chosen diet is: " + diet.GetName());
Console.WriteLine("You Need to eat: " + diet.GetMenu());







