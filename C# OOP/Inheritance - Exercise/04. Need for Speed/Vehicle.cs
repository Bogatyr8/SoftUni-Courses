using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create a base class Vehicle. It should contain the following members:
//A constructor that accepts the following parameters: int horsePower, double fuel
//DefaultFuelConsumption – double 
//FuelConsumption – virtual double
//Fuel – double
//HorsePower – int
//virtual void Drive(double kilometers)

namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25;
        public Vehicle(int horsePower, double fuel)
        {
            Fuel = fuel;
            HorsePower = horsePower;
        }

        public virtual double FuelConsumption => DefaultFuelConsumption;
        public double Fuel { get; set; }
        public int HorsePower { get; set; }

        public virtual void Drive(double kilometres)
        => Fuel -= kilometres * this.FuelConsumption;
    }
}
