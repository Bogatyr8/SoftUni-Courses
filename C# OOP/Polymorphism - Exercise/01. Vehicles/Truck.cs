using System;

namespace Vehicles;

public class Truck : Vehicle, ISummer
{
    private const double DamagedFuelTankModifier = 0.95;
    public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
    {
    }

    public double AdditionalAirConditionerConsumption => 1.6;

    public override void Drive(double distance)
    {
        double consumption = this.FuelConsumption + AdditionalAirConditionerConsumption;
        if (distance * consumption <= this.FuelQuantity)
        {
            this.FuelQuantity -= distance * consumption;
            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
        }
        else
        {
            Console.WriteLine($"{this.GetType().Name} needs refueling");
        }
    }

    public override void Refuel(double fuel)
    {
        base.Refuel(fuel * DamagedFuelTankModifier);
    }
}
