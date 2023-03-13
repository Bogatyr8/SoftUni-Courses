//Create a program that models 2 vehicles (a Car and a Truck) and simulates driving
// and refueling them.
//Car and truck both have fuel quantity, fuel consumption in liters per km, and can
//be driven a given distance and refueled with a given amount of fuel. It's summer,
//so both vehicles use air conditioners and their fuel consumption per km is 
//increased by 0.9 liters for the car and with 1.6 liters for the truck. Also,
//the truck has a tiny hole in its tank and when it’s refueled it keeps only 95% 
//of the given fuel. The car has no problems and adds all the given fuel to its
//tank. If a vehicle cannot travel the given distance, its fuel does not change.
//Input
//On the first line – information about the car in the format:
//"Car {fuel quantity} {liters per km}"
//On the second line – info about the truck in the format:
//"Truck {fuel quantity} {liters per km}"
//On the third line – the number of commands N that will be given on the
//next N lines
//On the next N lines – commands in the format:
//"Drive Car {distance}"
//"Drive Truck {distance}"
//"Refuel Car {liters}"
//"Refuel Truck {liters}"
//Output
//After each Drive command, if there was enough fuel, print on the console
//a message in the format:
//"Car/Truck travelled {distance} km"
//If there was not enough fuel, print: "Car/Truck needs refueling"
//After the End command, print the remaining fuel for both the car and the truck,
//rounded to 2 digits after the floating point in the format:
//"Car: {liters}"
//"Truck: {liters}"

using System;
using System.Collections.Generic;
using Vehicles;

List<ISummer> summerVehicles = new();

EntryOfVehicles(summerVehicles);

ManipulationOfVehicles(summerVehicles);

Print(summerVehicles);

static void EntryOfVehicles(List<ISummer> summerVehicles)
{
    for (int i = 0; i < 2; i++)
    {
        string[] input = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries);
        string type = input[0];
        double fuel = double.Parse(input[1]);
        double consumption = double.Parse(input[2]);
        if (type == "Car")
        {
            ISummer summerVehicle = new Car(fuel, consumption);
            summerVehicles.Add(summerVehicle);
        }
        else if (type == "Truck")
        {
            ISummer summerVehicle = new Truck(fuel, consumption);
            summerVehicles.Add(summerVehicle);
        }
    }
}

static void ManipulationOfVehicles(List<ISummer> summerVehicles)
{
    int n = int.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++)
    {
        string[] input = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries);
        string command = input[0];
        string type = input[1];
        double value = double.Parse(input[2]);
        if (command == "Drive")
        {
            foreach (ISummer v in summerVehicles)
            {
                if (type == "Car")
                {
                    Car car = v as Car;
                    if (car != null)
                    {
                        car.Drive(value);
                    }
                }
                else if (type == "Truck")
                {
                    Truck truck = v as Truck;
                    if (truck != null)
                    {
                        truck.Drive(value);
                    }
                }
            }
        }
        else if (command == "Refuel")
        {
            foreach (ISummer v in summerVehicles)
            {
                if (type == "Car")
                {
                    Car car = v as Car;
                    if (car != null)
                    {
                        car.Refuel(value);
                    }
                }
                else if (type == "Truck")
                {
                    Truck truck = v as Truck;
                    if (truck != null)
                    {
                        truck.Refuel(value);
                    }
                }
            }
        }
    }
}

static void Print(List<ISummer> summerVehicles)
{
    foreach (var vehicle in summerVehicles)
    {
        Console.WriteLine((Vehicle)vehicle);
    }
}