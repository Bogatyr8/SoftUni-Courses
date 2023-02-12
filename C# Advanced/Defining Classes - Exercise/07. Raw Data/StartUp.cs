//Create a program that tracks cars and their cargo. 
//Start by defining a class Car that holds information about:
//Model: a string property
//Engine: a class with two properties – speed and power,
//Cargo: a class with two properties – type and weight 
//Tires: a collection of exactly 4 tires. Each tire should have two properties: age and pressure.
//Create a constructor that receives all of the information about the Car and creates and
//initializes the model and its inner components (engine, cargo and tires).
//Input
//On the first line of input, you will receive a number N representing the number of cars you
//have. 
//1. On the next N lines, you will receive information about each car in the format:
//"{model} {engineSpeed} {enginePower} {cargoWeight} {cargoType} {tire1Pressure} {tire1Age} {tire2Pressure} {tire2Age} {tire3Pressure} {tire3Age} {tire4Pressure} {tire4Age}"
//The speed, power, weight and tire age are integers.
//The tire pressure is a floating point number. 
//2. Next, you will receive a single line with one of the following commands:  "fragile" or
//"flammable".
//Output
//As an output, if the command is:
//"fragile" - print all cars, whose cargo is "fragile" and have a pressure of a single tire < 1.
//"flammable" - print all cars, whose cargo is "flammable" and have engine power > 250.
//The cars should be printed in order of appearing in the input.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CarClasses;

public class StartUp
{
    public static void Main(string[] args)
    {
        List<Car> carList = new();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string model = input[0];
            int engineSpeed = int.Parse(input[1]);
            int enginePower = int.Parse(input[2]);
            int cargoWeight = int.Parse(input[3]);
            string cargoType = input[4];
            double tire1Pressure = double.Parse(input[5]);
            int tire1Age = int.Parse(input[6]);
            double tire2Pressure = double.Parse(input[7]);
            int tire2Age = int.Parse(input[8]);
            double tire3Pressure = double.Parse(input[9]);
            int tire3Age = int.Parse(input[10]);
            double tire4Pressure = double.Parse(input[11]);
            int tire4Age = int.Parse(input[12]);

            Engine engine = new(engineSpeed, enginePower);
            Cargo cargo = new(cargoWeight, cargoType);
            Car car = new(model, engine, cargo);
            car.CarTires(tire1Pressure, tire1Age);
            car.CarTires(tire2Pressure, tire2Age);
            car.CarTires(tire3Pressure, tire3Age);
            car.CarTires(tire4Pressure, tire4Age);

            carList.Add(car);
        }

        string search = Console.ReadLine();

        if (search == "fragile")
        {
            carList = carList.Where(c => c.SoftTire()).ToList();
        }
        else
        {
            carList = carList.Where(c => c.PowerfulEngine()).ToList();
        }

        foreach (Car car in carList)
        {
            Console.WriteLine(car.Model);
        }
    }
}