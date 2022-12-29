using System;

namespace _02.Weekend_or_Working_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма която, чете ден от седмицата(текст), на английски език - въведен от потребителя.Ако денят е работен отпечатва
            //на конзолата - "Working day", ако е почивен - "Weekend".Ако се въведе текст различен от ден от седмицата да се отпечата - "Error".
            string day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    Console.WriteLine("Working day");
                    break;
                case "Saturday":
                case "Sunday":
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
