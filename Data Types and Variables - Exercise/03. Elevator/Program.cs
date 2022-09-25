using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculate how many courses will be needed to elevate n persons by using an elevator of the capacity of p persons. The input
            //holds two lines: the number of people n and the capacity p of the elevator.
            int numberOfPeople = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            double numberOfCourses = (double)numberOfPeople / elevatorCapacity;
            double roundedNumberOfCourses = Math.Ceiling(numberOfCourses);

            Console.WriteLine(roundedNumberOfCourses);
        }
    }
}
