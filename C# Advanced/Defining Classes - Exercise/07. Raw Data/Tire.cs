using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Tires: a collection of exactly 4 tires. Each tire should have two properties: age and pressure.
namespace CarClasses
{
    public class Tire
    {
        private int age;
        private double pressure;
        public Tire(double pressure, int age)
        {
            this.Pressure = pressure;
            this.Age = age;
        }
        public int Age 
        {
            get 
            { 
                return this.age;
            }
            set
            {
                this.age = value;
            } 
        }
        public double Pressure 
        {
            get 
            {
                return this.pressure;
            }
            set
            {
                this.pressure = value;
            } 
        }
    }
}
