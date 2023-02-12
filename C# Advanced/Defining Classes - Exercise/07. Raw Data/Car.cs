using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Start by defining a class Car that holds information about:
//Model: a string property
//Engine: a class with two properties – speed and power,
//Cargo: a class with two properties – type and weight 
//Tires: a collection of exactly 4 tires. Each tire should have two properties: age and pressure.
//Create a constructor that receives all of the information about the Car and creates and
//initializes the model and its inner components (engine, cargo and tires).
namespace CarClasses
{
    internal class Car
    {
        private string model;
        private List<Tire> tires;

        public Car(string carModel, Engine engine, Cargo cargo)
        {
            this.Model= carModel;
            this.Engine = engine;
            this.Cargo = cargo;
            this.tires = new();
        }
        public string Model { get; set; }

        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }

        public void CarTires(double pressure, int age)
        {
            tires.Add(new Tire(pressure, age));
        }

        public bool SoftTire()
        {
            bool isThereASoftTire = false;
            foreach (var tire in tires)
            {
                if (tire.Pressure < 1)
                {
                    isThereASoftTire = true;
                }
            }
            return isThereASoftTire;
        }

        public bool PowerfulEngine()
        {
            return Engine.Power > 250;
        }
    }
}
