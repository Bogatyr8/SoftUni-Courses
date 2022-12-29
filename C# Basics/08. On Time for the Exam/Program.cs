using System;

namespace _08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            //Студент трябва да отиде на изпит в определен час(например в 9:30 часа).Той идва в изпитната зала в даден час на пристигане
            //(например 9:40).Счита се, че студентът е дошъл навреме, ако е пристигнал в часа на изпита или до половин час преди това.
            //Ако е пристигнал по-рано повече от 30 минути, той е подранил.Ако е дошъл след часа на изпита, той е закъснял.Напишете програма,
            //която прочита време на изпит и време на пристигане и отпечатва дали студентът е дошъл навреме, дали е подранил или е закъснял
            //и с колко часа или минути е подранил или закъснял.
            //Вход
            //От конзолата се четат 4 цели числа(по едно на ред), въведени от потребителя:
            //· Първият ред съдържа час на изпита – цяло число от 0 до 23.
            //· Вторият ред съдържа минута на изпита – цяло число от 0 до 59.
            //· Третият ред съдържа час на пристигане – цяло число от 0 до 23.
            //· Четвъртият ред съдържа минута на пристигане – цяло число от 0 до 59.
            //Изход
            //На първият ред отпечатайте:
            //· “Late”, ако студентът пристига по-късно от часа на изпита.
            //· “On time”, ако студентът пристига точно в часа на изпита или до 30 минути по-рано.
            //· “Early”, ако студентът пристига повече от 30 минути преди часа на изпита.
            //Ако студентът пристига с поне минута разлика от часа на изпита, отпечатайте на следващия ред:
            //· “mm minutes after the start” за закъснение под час.
            //· “hh: mm hours after the start” за закъснение от 1 час или повече.Минутите винаги печатайте с 2 цифри, например “1:03”.
            int hourExam = int.Parse(Console.ReadLine());
            int minuteExam = int.Parse(Console.ReadLine());
            int hourArrival = int.Parse(Console.ReadLine());
            int minuteArrival = int.Parse(Console.ReadLine());
            int convertedMinutesExam = hourExam * 60 + minuteExam;
            int convertedMinutesArrival = hourArrival * 60 + minuteArrival;
            int difference = convertedMinutesExam - convertedMinutesArrival;
            double diffHours = 0;
            double diffMinutes = 0;
            bool isItOnTime = difference == 0;
            bool isItEarlyWithin30Minutes = difference > 0 && difference <= 30;
            bool isItEarlyBetween30MinutesAndAnHour = difference > 30 && difference <= 59;
            bool isItEarlyMoreThanAnHour = difference >= 60;

            bool isItLateWithinAnHour = difference < 0 && difference >= -59;
            bool isItLateMoreThanAnHour = difference <= -60;
            if (isItOnTime)
            {
                Console.WriteLine("On time");
            }
            else if (isItEarlyWithin30Minutes)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{Math.Abs(difference)} minutes before the start");
            }
            else if (isItEarlyBetween30MinutesAndAnHour)
            {
                diffMinutes = Math.Abs(difference) % 60;
                Console.WriteLine("Early");
                Console.WriteLine($"{diffMinutes} minutes before the start");
            }
            else if (isItEarlyMoreThanAnHour)
            {
                diffHours = Math.Abs(difference) / 60;
                diffMinutes = Math.Abs(difference) % 60;
                Console.WriteLine("Early"); 
                if (diffMinutes <= 9)
                {
                    Console.WriteLine($"{diffHours}:0{diffMinutes} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{diffHours}:{diffMinutes} hours before the start");
                }
            }
            else if (isItLateWithinAnHour)
            {
                diffMinutes = Math.Abs(difference) % 60;
                Console.WriteLine("Late");
                Console.WriteLine($"{diffMinutes} minutes after the start");
            }
            else if (isItLateMoreThanAnHour)
            {
                diffHours = Math.Abs(difference) / 60;
                diffMinutes = Math.Abs(difference) % 60;
                Console.WriteLine("Late");
                if (diffMinutes <= 9)
                {
                    Console.WriteLine($"{diffHours}:0{diffMinutes} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{diffHours}:{diffMinutes} hours after the start");
                }
            }
        }
    }
}
