using System;

namespace _03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете от конзолата цели числа в диапазона, докато не се получи команда "stop". Да се намери сумата
            //на всички въведени прости и сумата на всички въведени непрости числа. Тъй като по дефиниция от математиката отрицателните
            //числа не могат да бъдат прости, ако на входа се подаде отрицателно число да се изведе следното съобщение
            //"Number is negative.". В този случай въведено число се игнорира и не се прибавя към нито една от двете суми, а програмата
            //продължава своето изпълнение, очаквайки въвеждане на следващо число. 
            //На изхода да се отпечатат на два реда двете намерени суми в следния формат:
            //•	"Sum of all prime numbers is: {prime numbers sum}"
            //•	"Sum of all non prime numbers is: {nonprime numbers sum}"
            string input = Console.ReadLine();
            int sumPrimes = 0;
            int sumNonPrimes = 0;
            while (input != "stop")
            {
                int number = int.Parse(input);
                int counterForPrime = 0;
                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }
                for (int i = 1; i <= number; i++)
                {

                    if (number % i == 0)
                    {
                        counterForPrime++;
                    }

                }
                if (number > 0)
                {
                    if (counterForPrime == 2)
                    {
                        sumPrimes += number;
                    }
                    else
                    {
                        sumNonPrimes += number;
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrimes}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrimes}");
        }
    }
}
