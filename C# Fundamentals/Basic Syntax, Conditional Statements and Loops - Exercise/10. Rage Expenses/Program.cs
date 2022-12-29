using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int loses = int.Parse(Console.ReadLine());
            float priceHeadset = float.Parse(Console.ReadLine());
            float priceMouse = float.Parse(Console.ReadLine());
            float priceKeyboard = float.Parse(Console.ReadLine());
            float priceDisplay = float.Parse(Console.ReadLine());

            int trashedHeadset = loses / 2;
            int trashedMouses = loses / 3;
            int trashedKeyboard = loses / 6;
            int trashedDisplay = loses / 12;
            float totalDamage = trashedHeadset * priceHeadset + trashedMouses * priceMouse 
                + trashedKeyboard * priceKeyboard + trashedDisplay * priceDisplay;

            Console.WriteLine($"Rage expenses: {totalDamage:f2} lv.");
        }
    }
}
