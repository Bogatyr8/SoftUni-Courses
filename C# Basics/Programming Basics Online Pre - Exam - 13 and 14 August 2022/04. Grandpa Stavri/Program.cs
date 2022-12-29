using System;

namespace _04._Grandpa_Stavri
{
    class Program
    {
        static void Main(string[] args)
        {
//Дядо Ставри има казан за ракия и всеки ден вари от любимата си напитка. Ако вари N дни и всеки ден
//получава различно количество ракия и алкохолен градус, да се намери за всички дни общото количество
//ракия и градуса на получената смес.
//Вход
//От конзолата се четат:
//•	На първия ред – N – броят дни  – цяло число в интервала[1...300]
//•	За всеки един ден на отделен ред:
//	количество на ракията – реално число в интервала[1.00...500.00]
//	градус на получената напитка -реално число в интервала[10.00...99.00]
//Изход
//Да се отпечатат на конзолата 3 реда:
//•	Първи ред: "Liter: {общо литрите}"
//•	Втори ред: "Degrees: {градусите на общата смес}"
//•	Трети ред – да се отпечатва един от следните редове:
//	"Not good, you should baking!" - ако градусът е по - малък от 38
//	"Super!" - ако градусът е от 38 до 42
//	"Dilution with distilled water!" - aко градусът е по - голям от 42
//Литрите и градусите да бъдат форматирани до втория знак след десетичната запетая.
            int days = int.Parse(Console.ReadLine());
            double totalLiters = 0;
            double totalDegrees = 0;
            for (int i = 1; i <= days; i++)
            {
                double liters = double.Parse(Console.ReadLine());
                double degrees = double.Parse(Console.ReadLine());
                totalLiters += liters;
                totalDegrees += degrees * liters;
            }
            double averageDegrees = totalDegrees / totalLiters;
            Console.WriteLine($"Liter: {totalLiters:f2}");
            Console.WriteLine($"Degrees: {averageDegrees:f2}");
            if (averageDegrees < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (averageDegrees >= 38 && averageDegrees <= 42)
            {
                Console.WriteLine("Super!");
            }
            else if (averageDegrees > 42)
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}
