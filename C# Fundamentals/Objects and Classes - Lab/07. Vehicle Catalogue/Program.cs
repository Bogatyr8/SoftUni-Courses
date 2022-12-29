using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Your task is to create a Vehicle catalog, which contains only Trucks and Cars.
            //Define a class Truck with the following properties: Brand, Model, and Weight.
            //Define a class Car with the following properties: Brand, Model, and Horse Power.
            //Define a class Catalog with the following properties: Collections of Trucks and Cars.
            //You must read the input, until you receive the "end" command.It will be in following format: "{type}/{brand}/{model}/{horse power / weight}"
            //In the end, you have to print all of the vehicles ordered alphabetical by brand, in the following format:
            //"Cars:
            //{Brand}: {Model} - { Horse Power}hp
            //Trucks:
            //{ Brand}: { Model} - { Weight}kg "
            string input;
            Catalog catalog = new Catalog();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] vehicleInfo = input.Split("/", StringSplitOptions.RemoveEmptyEntries);

                string type = vehicleInfo[0];
                string brand = vehicleInfo[1];
                string model = vehicleInfo[2];
                int value = int.Parse(vehicleInfo[3]);

                if (type == "Truck")
                {
                    Trucks truck = new Trucks(brand, model, value);
                    catalog.Trucks.Add(truck);
                }
                else
                {
                    Car car = new Car(brand, model, value);
                    catalog.Cars.Add(car);
                }
            }

            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
            }

            foreach (var car in catalog.Cars.OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }

            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
            }

            foreach (var truck in catalog.Trucks.OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }
    public class Catalog
    {
        public Catalog()
        {
            Cars = new List<Car>();
            Trucks = new List<Trucks>();
        }
        public List<Car> Cars { get; set; }
        public List<Trucks> Trucks { get; set; }
    }

public class Trucks
    {
        public Trucks(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    public class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
}

