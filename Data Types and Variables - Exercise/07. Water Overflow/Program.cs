using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
//You have a water tank with a capacity of 255 liters.On the next n lines, you will receive liters of water, which you have to pour
//into your tank.If the capacity is not enough, print "Insufficient capacity!" and continue reading the next line. On the last line,
//print the liters in the tank.
//Input
//The input will be on two lines:
//•	On the first line, you will receive n – the number of lines, which will follow
//•	On the next n lines – you receive quantities of water, which you have to pour into the tank
//Output
//Every time you do not have enough capacity in the tank to pour the given liters, print:
//Insufficient capacity!
//On the last line, print only the liters in the tank.
//Constraints
//•	n will be in the interval[1…20]
//•	liters will be in the interval[1…1000]
            int n = int.Parse(Console.ReadLine());
            int sumLiters = 0;
            for (int i = 0; i < n; i++)
            {
                int waterIntake = int.Parse(Console.ReadLine());
                sumLiters += waterIntake;
                if (sumLiters > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sumLiters -= waterIntake;
                }
            }
            Console.WriteLine(sumLiters);
        }
    }
}
