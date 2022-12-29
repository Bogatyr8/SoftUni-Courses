using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            //Габи иска да започне здравословен начин на живот и си е поставила за цел да върви 10 000 стъпки всеки ден. Някои дни обаче е
            //много уморена от работа и ще иска да се прибере преди да постигне целта си. Напишете програма, която чете от конзолата по колко
            //стъпки изминава тя всеки път, като излиза през деня и когато постигне целта си да се изписва "Goal reached! Good job!"  и колко
            //стъпки повече е извървяла "{разликата между стъпките} steps over the goal!"
            //Ако иска да се прибере преди това, тя ще въведе командата "Going home" и ще въведе стъпките, които е извървяла докато се
            //прибира.След което, ако не е успяла да постигне целта си, на конзолата трябва да се изпише:
            //"{разликата между стъпките} more steps to reach goal."
            int sumSteps = 0;
            int steps = 0;
            int flagForGoingHome = 0;
            int goal = 10000;
            string currentSteps = Console.ReadLine();
            bool isSheReady = !(sumSteps >= goal || flagForGoingHome == 1);
            bool didSheMade10KSteps = sumSteps >= goal;
            bool didSheFail = flagForGoingHome == 1;
            while (isSheReady)
            {
                if (currentSteps == "Going home")
                {
                    flagForGoingHome++;
                    currentSteps = Console.ReadLine();
                }
                steps = int.Parse(currentSteps);
                sumSteps += steps;
                isSheReady = !(sumSteps >= goal || flagForGoingHome == 1);
                didSheMade10KSteps = sumSteps >= goal;
                didSheFail = flagForGoingHome == 1;
                if (isSheReady)
                {
                    currentSteps = Console.ReadLine();
                }
            }
            if (didSheMade10KSteps)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{Math.Abs(sumSteps - goal)} steps over the goal!");
            }
            else if (didSheFail)
            {
                Console.WriteLine($"{Math.Abs(sumSteps - goal)} more steps to reach goal.");
            }
        }
    }
}
