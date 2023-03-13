using System;

namespace Vehicles;

public abstract class Vehicle
{
    public Vehicle(double fuelQuantity, double fuelConsumption)
    {
        FuelQuantity = fuelQuantity;
        FuelConsumption = fuelConsumption;
    }

    public double FuelQuantity { get; protected set; }
    public double FuelConsumption { get; protected set; }

    public abstract void Drive(double distance);
    public virtual void Refuel(double fuel)
    {
        FuelQuantity += fuel;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {FuelQuantity:f2}";
    }
}
