using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
//Start by defining a class Car that holds information about:
//Model: a string property
//Engine: a property holding the engine object
//Weight: an int property, it is optional
//Color: a string property, it is optional
namespace CarClasses
{
    internal class Car
    {
        private string model;
        private Engine engine = new();
        private int weight;
        private string color;
        public Car()
        {
            this.Model = null;
            this.Engine = null;
            this.Weight = 0;
            this.Color = null;
        }
        public Car(string carModel, Engine engine) : this()
        {
            this.Model = carModel;
            this.Engine = engine;
        }
        public Car(string carModel, Engine engine, int carWeight) : this(carModel, engine)
        {
            this.Weight = carWeight;
        }
        public Car(string carModel, Engine engine, string carColor) : this(carModel, engine)
        {
            this.Color = carColor;
        }
        public Car(string carModel, Engine engine, int carWeight, string carColor)
        {
            this.Model = carModel;
            this.Engine = engine;
            this.Weight = carWeight;
            this.Color = carColor;
        }

        public string Model { get; set; }
        public Engine Engine 
        {
            get 
            { 
                return this.engine;
            }
            set 
            { 
                this.engine = value;
            } 
        }
        public int Weight { get; set; }
        public string Color { get; set; }
    }
}
