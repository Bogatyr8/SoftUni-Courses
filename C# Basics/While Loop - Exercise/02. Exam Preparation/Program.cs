using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, в която Марин решава задачи от изпити докато не получи съобщение "Enough" от лектора си. При всяка решена
            //задача той получава оценка. Програмата трябва да приключи прочитането на данни при команда "Enough" или ако Марин получи
            //определения брой незадоволителни оценки. Незадоволителна е всяка оценка, която е по-малка или равна на 4.
            //Вход
            //•	На първи ред - брой незадоволителни оценки -цяло число в интервала[1…5]
            //•	След това многократно се четат по два реда:
            //o Име на задача -текст(низ)
            //o Оценка -цяло число в интервала[2…6]
            //Изход
            //•	Ако Марин стигне до командата "Enough", отпечатайте на 3 реда:
            //o"Average score: {средна оценка}"
            //o"Number of problems: {броя на всички задачи}"
            //o"Last problem: {името на последната задача}"
            //•	Ако получи определеният брой незадоволителни оценки:
            //o"You need a break, {брой незадоволителни оценки} poor grades."
            //Средната оценка да бъде форматирана до втория знак след десетичната запетая.
            int lowGrades = int.Parse(Console.ReadLine());
            int counter = 0;
            int lowGradeCounter = 0;
            int sum = 0;
            string nameOfTask = Console.ReadLine();
            int newGrades = 0;
            string lastTask = string.Empty;
            bool areThereTooManyLowGrades = lowGradeCounter == lowGrades;
            bool isItEnough = nameOfTask != "Enough";
            while (isItEnough)
            {
                newGrades = int.Parse(Console.ReadLine());
                lastTask = nameOfTask;
                bool isItALowGrade = newGrades <= 4;
                if (isItALowGrade)
                {
                    lowGradeCounter++;
                    areThereTooManyLowGrades = lowGradeCounter == lowGrades;
                    if (areThereTooManyLowGrades)
                    {
                        Console.WriteLine($"You need a break, {lowGrades} poor grades.");
                        break;
                    }
                }
                counter++;
                sum += newGrades;
                nameOfTask = Console.ReadLine();
                isItEnough = nameOfTask != "Enough";
            }
            if (!areThereTooManyLowGrades)
            {

                Console.WriteLine($"Average score: {((double)sum / counter):f2}");
                Console.WriteLine($"Number of problems: {counter}");
                Console.WriteLine($"Last problem: {lastTask}");
            }
        }
    }
}
