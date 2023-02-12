using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Cargo: a class with two properties – type and weight 
namespace CarClasses
{
    public class Cargo
    {
        private string type;
        private int weight;
        public Cargo(int weight, string type)
        {
            this.Weight = weight;
            this.Type = type;
        }
        public string Type { get; set; }
        public int Weight { get; set; }
    }
}
