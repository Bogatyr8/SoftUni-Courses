using System;

namespace Vehicles;

public class Car : Vehicle, ISummer
{
    public Car(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
    {
    }
    public double AdditionalAirConditionerConsumption => 0.9;

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
}
