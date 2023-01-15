namespace _07._Parking_Lot
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
//Create a program that:
//•	Records a car number for every car that enters the parking lot.
//•	Removes a car number when the car leaves the parking lot.
//The input will be a string in the format: "direction, carNumber".You will be receiving
//commands until the "END" command is given.
//Print the car numbers of the cars, which are still in the parking lot:
//Hints
//•	Car numbers are unique.
//•	Before printing, first check if the set has any elements.

            HashSet<string> parkingLot = new HashSet<string>();
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] inputArr = input
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string direction = inputArr[0];
                string plate = inputArr[1];
                if (direction.ToLower() == "in" && !CheckPlate(parkingLot, plate))
                {
                    parkingLot.Add(plate);
                }
                else if (direction.ToLower() == "out" && CheckPlate(parkingLot, plate))
                {
                    parkingLot.Remove(plate);
                }
            }
            if (parkingLot.Count > 0)
            {
                Console.WriteLine(String.Join("\n", parkingLot));
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }

        private static bool CheckPlate(HashSet<string> parkingLot, string plate)
        {
            return parkingLot.Contains(plate);
        }
    }
}
