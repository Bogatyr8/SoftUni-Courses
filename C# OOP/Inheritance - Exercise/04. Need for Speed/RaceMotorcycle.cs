using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        public RaceMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {

        }
        public override double FuelConsumption => 8;
        public virtual void Drive(double kilometres)
        => Fuel -= kilometres * this.FuelConsumption;
    }
}
