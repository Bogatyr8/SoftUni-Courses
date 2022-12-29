using System;

namespace _05._Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            //Производителите на вендинг машини искали да направят машините си да връщат възможно най - малко монети ресто. Напишете програма,
            //която приема сума -рестото, което трябва да се върне и изчислява с колко най-малко монети може да стане това.
            int counter = 0;
            double change = double.Parse(Console.ReadLine());
            double convertedChange = Math.Floor(change * 100);
            bool isThereMoreChange = convertedChange != 0;
            while (isThereMoreChange)
            {
                if (convertedChange >= 200)
                {
                    convertedChange -= 200;
                    counter++;
                }
                else if (convertedChange >= 100)
                {
                    convertedChange -= 100;
                    counter++;
                }
                else if (convertedChange >= 50)
                {
                    convertedChange -= 50;
                    counter++;
                }
                else if (convertedChange >= 20)
                {
                    convertedChange -= 20;
                    counter++;
                }
                else if (convertedChange >= 10)
                {
                    convertedChange -= 10;
                    counter++;
                }
                else if (convertedChange >= 5)
                {
                    convertedChange -= 5;
                    counter++;
                }
                else if (convertedChange >= 2)
                {
                    convertedChange -= 2;
                    counter++;
                }
                else if (convertedChange >= 1)
                {
                    convertedChange -= 1;
                    counter++;
                }
                isThereMoreChange = convertedChange != 0;
            }
            Console.WriteLine(counter);
        }
    }
}
