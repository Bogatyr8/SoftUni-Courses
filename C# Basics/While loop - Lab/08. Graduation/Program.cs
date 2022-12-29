using System;

namespace _08._Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
//Напишете програма, която изчислява средната оценка на ученик от цялото му обучение. На първия ред ще получите името на ученика, а на
//всеки следващ ред неговите годишни оценки. Ученикът преминава в следващия клас, ако годишната му оценка е по-голяма или равна на 4.00.
//Ако ученикът бъде скъсан повече от един път, то той бива изключен и програмата приключва, като се отпечатва името на ученика и в кой
//клас бива изключен.
// При успешно завършване на 12-ти клас да се отпечата: 
//"{име на ученика} graduated. Average grade: {средната оценка от цялото обучение}"
//В случай, че ученикът е изключен от училище, да се отпечата:
//"{име на ученика} has been excluded at {класа, в който е бил изключен} grade"
//Стойността трябва да бъде форматирана до втория знак след десетичната запетая.
            int grade = 0;
            double sumOfValue = 0;
            int penalty = 0;
            string nameOfStudent = Console.ReadLine();
            double value = 0;
            while (!(grade == 12))
            {
                value = double.Parse(Console.ReadLine());
                sumOfValue += value;
                if (value <= 3)
                {
                    penalty++;
                    if (penalty == 2)
                    {
                        Console.WriteLine($"{nameOfStudent} has been excluded at {grade} grade");
                        break;
                    }
                }
                grade++;
            }
            if (penalty < 2)
            {
                Console.WriteLine($"{nameOfStudent} graduated. Average grade: {(sumOfValue / grade):f2}"); 
            }
        }
    }
}
