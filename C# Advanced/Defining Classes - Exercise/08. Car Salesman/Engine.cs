using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Next, the Engine class has the following properties:
//Model: a string property
//Power: an int property
//Displacement: an int property, it is optional
//Efficiency: a string property, it is optional
namespace CarClasses
{
    internal class Engine
    {
        private string model;
        private int power;
        private int displacement;
        private string efficiency;

        public Engine() 
        { 
            this.Model = null;
            this.Power = 0;
            this.Displacement = 0;
            this.Efficiency = null;

        }

        public Engine(string engineModel, int enginePower) : this() 
        {
            this.Model = engineModel;
            this.Power = enginePower;
        }
        public Engine(string engineModel, int enginePower, int engineDisplacement) : this(engineModel, enginePower)
        {
            this.Displacement = engineDisplacement;
        }
        public Engine(string engineModel, int enginePower, string engineEfficiency) : this(engineModel, enginePower)
        {
            this.Efficiency = engineEfficiency;
        }
        public Engine(string engineModel, int enginePower, int engineDisplacement, string engineEfficiency)
        {
            this.Model = engineModel;
            this.Power = enginePower;
            this.Displacement = engineDisplacement;
            this.Efficiency = engineEfficiency;
        }
        public string Model { get; set; }
        public int Power { get; set; }
        public int Displacement { get; set; }
        public string Efficiency { get; set; }
    }
}
