using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
//Let’s suppose there is a circular route for lorries.There are N petrol pumps on that toute.Petrol pumps
//are numbered 0 to(N−1)(both inclusive).You will receive information(array), corresponding to each of
//the petrol pumps: [0] the amount of petrol(in litres) that particular petrol pump will give, and[1]
//the distance(in kilometers) from the current petrol pump to the next petrol pump.
//You have a tank of infinite capacity carrying no petrol. Your task is to figure out, which is the
//first possible petrol pump, from which the lorry will be able to complete the route.Consider that the
//lorry will stop at each of the petrol pumps. The lorry will move one kilometer for each liter of
//petrol.
//Input
//•	The first line will contain the value of N
//•	The next N lines will contain a pair of integers each, i.e.the amount of petrol that petrol pump
//will give and the distance between that petrol pump and the next petrol pump.
//Output
//•	An integer which will be the smallest index of the petrol pump from which we can start the tour.
//Constraints
//•	1 ≤ N ≤ 1000001
//•	1 ≤ Amount of petrol, Distance ≤ 1000000000
            long n = long.Parse(Console.ReadLine());
            Queue<BigInteger> pumpIndex = new Queue<BigInteger>();
            Queue<BigInteger> distanceToNextPump = new Queue<BigInteger>();
            Queue<BigInteger> fuel = new Queue<BigInteger>();
            FormingTheQueues(pumpIndex, distanceToNextPump, fuel, n);

            BigInteger tank = 0;
            long validPump = -1;
            for (long i = 0; i < n; i++)
            {
                Queue<BigInteger> currPumpIndex = new Queue<BigInteger>(pumpIndex);
                Queue<BigInteger> currDistanceToNextPump = new Queue<BigInteger>(distanceToNextPump);
                Queue<BigInteger> currFuel = new Queue<BigInteger>(fuel);

                if (i != 0)
                {
                    CheckingNextPump(currPumpIndex, currDistanceToNextPump, currFuel, i);
                }

                validPump = JourneySimulation(currPumpIndex, currDistanceToNextPump, currFuel, i, tank);

                if (validPump != -1)
                {
                    break;
                }
            }

            if (validPump != -1)
            {
                Console.WriteLine(validPump);
            }


        }

        private static void FormingTheQueues(Queue<BigInteger> pumpIndex, Queue<BigInteger> distanceToNextPump, Queue<BigInteger> fuel, long n)
        {
            for (int i = 0; i < n; i++)
            {
                BigInteger[] petrolStation = Console.ReadLine()
                    .Split()
                    .Select(BigInteger.Parse)
                    .ToArray();
                BigInteger petrol = petrolStation[0];
                BigInteger distance = petrolStation[1];
                pumpIndex.Enqueue(i);
                distanceToNextPump.Enqueue(distance);
                fuel.Enqueue(petrol);
            }
        }

        private static void CheckingNextPump(Queue<BigInteger> currPumpIndex, Queue<BigInteger> currDistanceToNextPump, Queue<BigInteger> currFuel, long i)
        {
            for (int j = 0; j < i; j++)
            {
                BigInteger temp1 = currPumpIndex.Dequeue();
                BigInteger temp2 = currDistanceToNextPump.Dequeue();
                BigInteger temp3 = currFuel.Dequeue();
                currPumpIndex.Enqueue(temp1);
                currDistanceToNextPump.Enqueue(temp2);
                currFuel.Enqueue(temp3);
            }
        }

        private static long JourneySimulation(Queue<BigInteger> currPumpIndex, Queue<BigInteger> currDistanceToNextPump, Queue<BigInteger> currFuel, long i, BigInteger tank)
        {
            bool isItEnoughToNextStation = true;
            while (currPumpIndex.Count > 0 && isItEnoughToNextStation)
            {
                currPumpIndex.Dequeue();
                BigInteger currentDistance = currDistanceToNextPump.Dequeue();
                BigInteger currentFuel = currFuel.Dequeue();
                tank += currentFuel;
                isItEnoughToNextStation = tank >= currentDistance;
                if (isItEnoughToNextStation)
                {
                    tank -= currentDistance;
                }
            }
            if (currPumpIndex.Count == 0)
            {
                return i;
            }
            else
            {
                return -1;
            }
        }
    }
}
