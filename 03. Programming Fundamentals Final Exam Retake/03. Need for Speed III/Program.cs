using System;
using System.Collections.Generic;

namespace _03._Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {
//You have just bought the latest and greatest computer game – Need for Seed III. Pick your favorite cars and drive them all you want! We know that you can't wait to start playing.
//On the first line of the standard input, you will receive an integer n – the number of cars that you can obtain.On the next n lines, the cars themselves will follow with their mileage and fuel available, separated by "|" in the following format:
//"{car}|{mileage}|{fuel}"
//Then, you will be receiving different commands, each on a new line, separated by " : ", until the "Stop" command is given:
//•	"Drive : {car} : {distance} : {fuel}":
//o   You need to drive the given distance, and you will need the given fuel to do that.If the car doesn't have enough fuel, print: "Not enough fuel to make that ride"
//o If the car has the required fuel available in the tank, increase its mileage with the given distance, decrease its fuel with the given fuel, and print:
//"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed."
//o You like driving new cars only, so if a car's mileage reaches 100 000 km, remove it from the collection(s) and print: "Time to sell the {car}!"
//•	"Refuel : {car} : {fuel}":
//o Refill the tank of your car.
//o Each tank can hold a maximum of 75 liters of fuel, so if the given amount of fuel is more than you can fit in the tank, take only what is required to fill it up.
//o Print a message in the following format: "{car} refueled with {fuel} liters"
//•	"Revert : {car} : {kilometers}":
//o Decrease the mileage of the given car with the given kilometers and print the kilometers you have decreased it with in the following format:
//"{car} mileage decreased by {amount reverted} kilometers"
//o If the mileage becomes less than 10 000km after it is decreased, just set it to 10 000km and
//DO NOT print anything.
//Upon receiving the "Stop" command, you need to print all cars in your possession in the following format:
//"{car} -> Mileage: {mileage} kms, Fuel in the tank: {fuel} lt."
//Input / Constraints
//•	The mileage and fuel of the cars will be valid, 32 - bit integers, and will never be negative.
//•	The fuel and distance amounts in the commands will never be negative.
//•	The car names in the commands will always be valid cars in your possession.
//Output
//•	All the output messages with the appropriate formats are described in the problem description.
            Dictionary<string, int[]> cars = new Dictionary<string, int[]>();
            ObtainingCars(cars);
            MovingTheCars(cars);
            PrintingList(cars);
        }

        static void ObtainingCars(Dictionary<string, int[]> cars)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] carInput = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);
                string carBrand = carInput[0];
                int carMileage = int.Parse(carInput[1]);
                int carFuel = int.Parse(carInput[2]);
                cars[carBrand] = new int[2] { carMileage, carFuel };
            }
        }

        static void MovingTheCars(Dictionary<string, int[]> cars)
        {
            string cmdInput;
            while ((cmdInput = Console.ReadLine()) != "Stop")
            {
                string[] commArg = cmdInput
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string command = commArg[0];
                string car = commArg[1];
                if (command == "Drive")                             //"{car}|{mileage}|{fuel}"
                {
                    int distance = int.Parse(commArg[2]);
                    int fuel = int.Parse(commArg[3]);
                    if (cars[car][1] < fuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        cars[car][0] += distance;
                        cars[car][1] -= fuel;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                        if (cars[car][0] >= 100000)
                        {
                            cars.Remove(car);
                            Console.WriteLine($"Time to sell the {car}!");
                        }
                    }
                }
                else if (command == "Refuel")
                {
                    int fuel = int.Parse(commArg[2]);
                    int filledFuel = cars[car][1] + fuel;
                    if (filledFuel >= 75)
                    {
                        int overFuel = filledFuel - 75;
                        cars[car][1] = 75;
                        Console.WriteLine($"{car} refueled with {fuel - overFuel} liters");
                    }
                    else
                    {
                        cars[car][1] += fuel;
                        Console.WriteLine($"{car} refueled with {fuel} liters");
                    }
                }
                else if (command == "Revert")
                {
                    int kilometers = int.Parse(commArg[2]);
                    cars[car][0] -= kilometers;
                    if (cars[car][0] >= 10000)
                    {
                        Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                    }
                    else
                    {
                        cars[car][0] = 10000;
                    }
                }
            }
        }

        static void PrintingList(Dictionary<string, int[]> cars)
        {
            foreach (var (vehicle, carStats) in cars)
            {
                Console.WriteLine($"{vehicle} -> Mileage: {carStats[0]} kms, Fuel in the tank: {carStats[1]} lt.");
            }
        }
    }
}
