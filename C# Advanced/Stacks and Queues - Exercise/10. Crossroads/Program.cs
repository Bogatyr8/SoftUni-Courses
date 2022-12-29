namespace _10._Crossroads
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
//Our favorite super - spy action hero Sam is back from his mission from the previous exam and he has
//finally found some time to go on a holiday. He is taking his wife somewhere nice and they're going to
//have a really good time, but first, they have to get there. Even on his holiday trip, Sam is still going
//to run into some problems and the first one is, of course, getting to the airport. Right now, he is stuck
//in a traffic jam at a very active crossroad where a lot of accidents happen.
//Your job is to keep track of traffic at the crossroads and report whether a crash happened or everyone
//passed the crossroads safely and our hero is one step closer to a much-desired vacation.
//The road Sam is on has a single lane where cars queue up until the light goes green. When it does, they
//start passing one by one during the green light and the free window before the intersecting road's light
//goes green. During one second only one part of a car (a single character) passes the crossroads. If a car
//is still at the crossroads when the free window ends, it will get hit at the first character that is
//still in the crossroads.
//Input
//•	On the first line, you will receive the duration of the green light in seconds – an integer in the
//range[1…100].
//•	On the second line, you will receive the duration of the free window in seconds – an integer in the
//range[0…100].
//•	On the following lines, until you receive the "END" command, you will receive one of two things:
//	A car – a string containing any ASCII character, or
//	The command "green" indicates the start of a green light cycle
//A green light cycle goes as follows:
//•	During the green light, cars will enter and exit the crossroads one by one.
//•	During the free window, cars will only exit the crossroads.
//Output
//•	If a crash happens, end the program and print:
//"A crash happened!"
//"{car} was hit at {characterHit}."
//•	If everything goes smoothly and you receive an "END" command, print:
//"Everyone is safe.".
//"{totalCarsPassed} total cars passed the crossroads.".
//Constraints
//•	The input will be within the constraints specified above and will always be valid. There is no need to
//check it explicitly.
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            int green = greenLight;
            int free = freeWindow;
            Queue<string> cars = new Queue<string>();
            int carsPassedCnt = 0;
            bool isThereACrash = false;
            string currCar = " ";
            char hittedOnChar = ' ';
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                if (input != "green")
                {
                    if (greenLight > 0)
                    {
                        greenLight -= input.Length;
                        cars.Enqueue(input);
                    }
                }
                else
                {
                    greenLight = green;
                    freeWindow = free;
                    ProcesingPassingCars(cars, greenLight, freeWindow, ref carsPassedCnt, ref isThereACrash, ref hittedOnChar, ref currCar);
                    greenLight = green;
                    freeWindow = free;
                    if (isThereACrash)
                    {
                        break;
                    }
                }
            }
            if (!isThereACrash)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{carsPassedCnt} total cars passed the crossroads.");
            }
            else
            {
                Console.WriteLine("A crash happened!");
                Console.WriteLine($"{currCar} was hit at {hittedOnChar}.");
            }
        }
        private static void ProcesingPassingCars(Queue<string> cars, int greenLight, int freeWindow, ref int carsPassedCnt, ref bool isThereACrash, ref char hittedOnChar, ref string currCar)
        {
            while (cars.Count != 0)
            {
                currCar = cars.Dequeue();

                if (currCar.Length <= greenLight)
                {
                    greenLight -= currCar.Length;
                    carsPassedCnt++;
                }
                else if (greenLight < currCar.Length && currCar.Length <= greenLight + freeWindow)
                {
                    greenLight -= currCar.Length;
                    freeWindow += greenLight;
                    carsPassedCnt++;
                }
                else if (currCar.Length > greenLight + freeWindow)
                {
                    isThereACrash = true;
                    hittedOnChar = Crash(currCar, greenLight, freeWindow);

                    return;
                }
            }
        }
        private static char Crash(string currCar, int greenLight, int freeWindow)
        {
            Queue<char> passingCar = new Queue<char>(currCar);
            for (int i = 0; i < greenLight + freeWindow; i++)
            {
                passingCar.Dequeue();
            }
            return passingCar.Dequeue();
        }
    }
}
