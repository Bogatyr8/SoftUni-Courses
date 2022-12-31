namespace _12._Cups_and_Bottles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
//You will be given a sequence of integers – each indicating a cup's capacity. After that, you will be
//given another sequence of integers – a bottle with water in it. Your job is to try to fill up all of
//the cups.
//The filling is done by picking exactly one bottle at a time.You must start picking from the last received
//bottle and start filling from the first entered cup.If the current bottle has N water, you give the first
//entered cup N water and reduce its integer value by N.
//When a cup's integer value reaches 0 or less, it gets removed. The current cup's value may be greater
//than the current bottle's value. In that case, you pick bottles until you reduce the cup's integer value
//to 0 or less. If a bottle's value is greater or equal to the cup's current value, you fill up the cup,
//and the remaining water becomes wasted. You should keep track of the wasted litter of water and print it
//at the end of the program.
//If you have managed to fill up all of the cups, print the remaining water bottles, from the last
//entered – to the first, otherwise you must print the remaining cups, by order of entrance – from the
//first entered – to the last.
//Input
//•	On the first line of input, you will receive the integers, representing the cups' capacity, separated
//by a single space. 
//•	On the second line of input, you will receive the integers, representing the filled bottles, separated
//by a single space.
//Output
//•	On the first line of output, you must print the remaining bottles or the remaining cups, depending on
//the case you are in. Just keep the orders of printing exactly as specified.
//o   "Bottles: {remainingBottles}" or "Cups: {remainingCups}"
//•	On the second line, print the wasted litters of water in the following format: "Wasted litters of
//water: {wastedLittersOfWater}".
//Constraints
//•	All of the given numbers will be valid integers in the range[1…500].
//•	It is safe to assume that there will be NO case in which the water is exactly as much as the cups'
//values so that at the end there are no cups and no water in the bottles.
//•	Allowed time/ memory: 100ms / 16MB.
            int[] cupsArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] bottlesArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Queue<int> cups = new Queue<int>(cupsArr);
            Stack<int> bottles = new Stack<int>(bottlesArr);
            int wastedWater = 0;

            while (cups.Any() && bottles.Any())
            {
                int cup = cups.Peek();
                int bottle = bottles.Pop();
                cup -= bottle;
                if (cup > 0)
                {
                    FillTheCup(bottles, cups, ref wastedWater, ref cup);
                }
                else if (cup == 0)
                {
                    cups.Dequeue();
                }
                else
                {
                    cups.Dequeue();
                    wastedWater += Math.Abs(cup);
                }
            }

            if (cups.Any())
            {
                Console.WriteLine($"Cups: {String.Join(" ", cups)}");
            }
            else if (bottles.Any())
            {
                Console.WriteLine($"Bottles: {String.Join(" ", bottles)}");
            }

            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }

        private static void FillTheCup(Stack<int> bottles, Queue<int> cups, ref int wastedWater, ref int cup)
        {
            cup -= bottles.Pop();
            if (cup > 0)
            {
                FillTheCup(bottles, cups, ref wastedWater, ref cup);
            }
            else if (cup == 0)
            {
                cups.Dequeue();
            }
            else
            {
                cups.Dequeue();
                wastedWater += Math.Abs(cup);
            }
        }
    }
}
