using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
//Until you receive the "End" command, you will be receiving lines of input in the following format:
//"{typeOfVehicle} {model} {color} {horsepower}"
//When you receive the "End" command, you will start receiving information about some vehicles.
//For every vehicle, print out the information about it in the following format:
//"Type: {typeOfVehicle}
//Model: { modelOfVehicle}
//Color: { colorOfVehicle}
//Horsepower: { horsepowerOfVehicle}"
//When you receive the "Close the Catalogue" command, print out the average horsepower of the cars and the average horsepower of the
//trucks in the format:
//"{typeOfVehicles} have average horsepower of {averageHorsepower}."
//The average horsepower is calculated by dividing the sum of the horsepower of all vehicles of the given type by the total count of
//all vehicles from that type.Format the answer to the second digit after the decimal point.
//Constraints
//•	The type of vehicle will always be either a car or a truck.
//•	You will not receive the same model twice.
//•	The received horsepower will be an integer in the range[1…1000].
//•	You will receive at most 50 vehicles.
//•	The separator will always be single whitespace.
            List<Vehicle> trucks = new List<Vehicle>();
            List<Vehicle> cars = new List<Vehicle>();
            string inputString;
            while ((inputString = Console.ReadLine()) != "End")
            {
                string[] input = inputString
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string type = input[0];

                StringBuilder sb = new StringBuilder();
                sb.Append(input[1]);
                for (int i = 2; i < input.Length - 2; i++)
                {
                    if (i != input.Length - 2)
                    {
                        sb.Append($" {input[i]}");
                    }
                }
                string model = sb.ToString();
                string color = input[input.Length - 2];
                if (!int.TryParse(input[input.Length - 1], out int horsePower))
                {
                    continue;
                }
                if (type == "truck")
                {
                    Vehicle currTruck = new Vehicle("Truck", model, color, horsePower);
                    trucks.Add(currTruck);
                }
                else if (type == "car")
                {
                    Vehicle currCar = new Vehicle("Car", model, color, horsePower);
                    cars.Add(currCar);
                }
            }

            while ((inputString = Console.ReadLine()) != "Close the Catalogue")
            {
                foreach (var item in trucks)
                {
                    if (item.Model == inputString)
                    {
                        Console.WriteLine($"Type: {item.Type}\nModel: {item.Model}\nColor: {item.Color}\nHorsepower: {item.HorsePower}");
                    }
                }
                foreach (var item in cars)
                {
                    if (item.Model == inputString)
                    {
                        Console.WriteLine($"Type: {item.Type}\nModel: {item.Model}\nColor: {item.Color}\nHorsepower: {item.HorsePower}");
                    }
                }
            }

            double carsAverage = 0.0;
            double trucksAverage = 0.0;
            if (cars.Count > 0)
            {
                carsAverage = cars.Average(c => c.HorsePower);
            }
            if (trucks.Count > 0)
            {
                trucksAverage = trucks.Average(t => t.HorsePower);
            }
            Console.WriteLine($"Cars have average horsepower of: {carsAverage:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAverage:f2}.");
        }
    }

    public class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }
        public string Type { get; private set; }
        public string Model { get; private set; }
        public string Color { get; private set; }
        public int HorsePower { get; private set; }
    }
}
