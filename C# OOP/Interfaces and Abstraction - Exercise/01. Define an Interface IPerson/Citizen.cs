using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfo;

public class Citizen : IPerson
{
    public Citizen(string name, int age)
    {
        Age = age;
        Name = name;
    }

    public int Age { get; set; }
    public string Name { get; set; }
}
