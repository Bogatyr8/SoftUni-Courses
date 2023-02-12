using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClasses
{
    internal class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance;

        public Car(string carModel, double fuelTank, double fuelPerKm)
        {
            this.Model = carModel;
            this.FuelAmount = fuelTank;
            this.FuelConsumptionPerKilometer = fuelPerKm;
            this.TravelledDistance = 0.0;
        }
        public string Model 
        { 
            get 
            { 
                return this.model; 
            } 
            set 
            {
                this.model = value; 
            } 
        }
        public double FuelAmount 
        { 
            get 
            { 
                return this.fuelAmount; 
            } 
            set 
            {
                this.fuelAmount = value; 
            } 
        }
        public double FuelConsumptionPerKilometer 
        { 
            get 
            {
                return this.fuelConsumptionPerKilometer; 
            } 
            set 
            {
                this.fuelConsumptionPerKilometer = value;
            } 
        }
        public double TravelledDistance
        {
            get
            {
                return this.travelledDistance;
            }
            set 
            {
                this.travelledDistance = value; 
            }
        }

        public void CarMovement(double distance)
        {
            double fuelConsumption = distance * this.fuelConsumptionPerKilometer;
            if (this.fuelAmount >= fuelConsumption)
            {
                this.travelledDistance += distance;
                this.fuelAmount -= fuelConsumption;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
