using System;

namespace _09.FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            double deadPercentage = double.Parse(Console.ReadLine());

            double volume = length * width * hight;
            double volumeInLitres = volume / 1000;
            double realVolume = volumeInLitres * (1 - deadPercentage / 100);
            Console.WriteLine(realVolume);
        }
    }
}