using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Курсът "Train the trainers" е към края си и финалното оценяване наближава. Вашата задача е
            //да помогнете на журито което ще оценява презентациите, като напишете програма в която да
            //изчислява средната оценка от представянето на всяка една презентация от даден студент, а
            //накрая средният успех от всички тях.
            //От конзолата на първият ред се прочита броят на хората в журито n - цяло число в
            //интервала[1…20]
            //След това на отделен ред се прочита името на презентацията -текст
            //За всяка една презентация на нов ред се четат n -на брой оценки -реално число в
            //интервала[2.00…6.00]
            //След изчисляване на средната оценка за конкретна презентация, на конзолата се печата
            // "{името на презентацията} - {средна оценка}."
            //След получаване на команда "Finish" на конзолата се печата "Student's final assessment
            //is {среден успех от всички презентации}." и програмата приключва.
            //Всички оценки трябва да бъдат форматирани до втория знак след десетичната запетая.
            int numberOfJuree = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();
            double archiveScore = 0;
            double totalCounterOfVotes = 0;
            while (presentation != "Finish")
            {
                double totalScore = 0;
                for (int i = 0; i < numberOfJuree; i++)
                {
                     double score = double.Parse(Console.ReadLine());
                    totalScore += score;
                    archiveScore += score;
                    totalCounterOfVotes++;
                }
                Console.WriteLine($"{presentation} - {(totalScore / numberOfJuree):f2}.");
                presentation = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {archiveScore / totalCounterOfVotes:f2}.");
        }
    }
}
