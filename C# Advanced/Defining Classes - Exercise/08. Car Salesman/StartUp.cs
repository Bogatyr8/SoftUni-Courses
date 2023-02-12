//Define two classes Car and Engine. 
//Start by defining a class Car that holds information about:
//Model: a string property
//Engine: a property holding the engine object
//Weight: an int property, it is optional
//Color: a string property, it is optional
//Next, the Engine class has the following properties:
//Model: a string property
//Power: an int property
//Displacement: an int property, it is optional
//Efficiency: a string property, it is optional
//Input
//1. On the first line, you will read a number N, which will specify how many lines of engines you will
//receive. 
//On each of the next N lines, you will receive information about an Engine in the following format:
//"{model} {power} {displacement} {efficiency}"
//Keep in mind that "displacement" and "efficiency" are optional, they could be missing from the command.
//2. Next, you will receive a number M, which will specify how many lines of car you will receive. 
//On each of the next M lines, you will receive information about a Car in the following format:
//"{model} {engine} {weight} {color}".
//Keep in mind that "weight" and "color" are optional, they could be missing from the command.
//The "engine" will always be the model of an existing Engine.
//When creating the object for a Car, you should keep a reference to the real engine in it, instead of just
//the engine's model. 
//Note: The optional properties might be missing from the formats.
//Output
//Your task is to print all the cars in the order they were received and their information in the format
//defined below. If any of the optional fields are missing, print "n/a" in its place:
//"{CarModel}:
//  { EngineModel}:
//    Power: { EnginePower}
//Displacement: { EngineDisplacement}
//Efficiency: { EngineEfficiency}
//Weight: { CarWeight}
//Color: { CarColor}
//"
//Bonus*
//Override the classes' "ToString()" methods to have a reusable way of displaying the objects.
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CarClasses;

public class StartUp
{
    public static void Main(string[] args)
    {
        Dictionary<string, Engine> engineCatalog = new();
        List<Car> carsCatalog = new();

        GettingEngines(engineCatalog);

        GettingCars(engineCatalog, carsCatalog);

        Print(carsCatalog);

    }


    private static void GettingEngines(Dictionary<string, Engine> engineCatalog)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] engineDetails = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string model = engineDetails[0];
            int power = int.Parse(engineDetails[1]);
            int displacement;
            string efficiency;
            if (engineDetails.Length == 2)
            {
                Engine engine = new(model, power);
                engineCatalog.Add(model, engine);
            }
            else if (engineDetails.Length == 3)
            {
                if (int.TryParse(engineDetails[2], out int result))
                {
                    displacement = result;
                    Engine engine = new(model, power, displacement);
                    engineCatalog.Add(model, engine);
                }
                else
                {
                    efficiency = engineDetails[2];
                    Engine engine = new(model, power, efficiency);
                    engineCatalog.Add(model, engine);
                }

            }
            else if (engineDetails.Length == 4)
            {
                displacement = int.Parse(engineDetails[2]);
                efficiency = engineDetails[3];
                Engine engine = new(model, power, displacement, efficiency);
                engineCatalog.Add(model, engine);
            }
        }
    }

    private static void GettingCars(Dictionary<string, Engine> engineCatalog, List<Car> carsCatalog)
    {
        int m = int.Parse(Console.ReadLine());

        for (int i = 0; i < m; i++)
        {
            string[] carDetails = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string model = carDetails[0];
            string engineModel = carDetails[1];
            int weight;
            string color;
            if (carDetails.Length == 2)
            {
                Car car = new(model, engineCatalog[engineModel]);
                carsCatalog.Add(car);
            }
            else if (carDetails.Length == 3)
            {
                if (int.TryParse(carDetails[2], out int result))
                {
                    weight = result;
                    Car car = new(model, engineCatalog[engineModel], weight);
                    carsCatalog.Add(car);
                }
                else
                {
                    color = carDetails[2];
                    Car car = new(model, engineCatalog[engineModel], color);
                    carsCatalog.Add(car);
                }
            }
            else if (carDetails.Length == 4)
            {
                weight = int.Parse(carDetails[2]);
                color = carDetails[3];
                Car car = new(model, engineCatalog[engineModel], weight, color);
                carsCatalog.Add(car);
            }
        }
    }
    private static void Print(List<Car> carsCatalog)
    {
        StringBuilder sb = new();
        foreach (Car car in carsCatalog)
        {
            sb.AppendLine($"{car.Model}:");
            sb.AppendLine($" {car.Engine.Model}:");
            sb.AppendLine($"    Power: {car.Engine.Power}");
            if (car.Engine.Displacement != 0)
            {
                sb.AppendLine($"    Displacement: {car.Engine.Displacement}");
            }
            else
            {
                sb.AppendLine($"    Displacement: n/a");
            }
            if (car.Engine.Efficiency != null)
            {
                sb.AppendLine($"    Efficiency: {car.Engine.Efficiency}");
            }
            else
            {

                sb.AppendLine($"    Efficiency: n/a");
            }
            if (car.Weight != 0)
            {
                sb.AppendLine($" Weight: {car.Weight}");
            }
            else
            {

                sb.AppendLine($" Weight: n/a");
            }
            if (car.Color != null)
            {
                sb.AppendLine($" Color: {car.Color}");
            }
            else
            {

                sb.AppendLine($" Color: n/a");
            }
        }

        Console.WriteLine(sb.ToString());
    }
}