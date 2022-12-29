using System;

namespace _06._CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вашата задача е да напишете програма, която да изчислява процента на билетите за всеки тип от
            //продадените билети: студентски(student), стандартен(standard) и детски(kid), за всички прожекции.Трябва
            //да изчислите и колко процента от залата е запълнена за всяка една прожекция.
            //Вход
            //Входът е поредица от цели числа и текст:
            // На първия ред до получаване на командата "Finish" - име на филма – текст
            // На втори ред – свободните места в салона за всяка прожекция – цяло число[1... 100]
            // За всеки филм, се чете по един ред до изчерпване на свободните места в залата или до получаване на
            //командата "End":
            //o Типа на закупения билет - текст("student", "standard", "kid")
            //Изход
            //На конзолата трябва да се печатат следните редове:
            // След всеки филм да се отпечата, колко процента от кино залата е пълна
            //"{името на филма} - {процент запълненост на залата}% full."
            // При получаване на командата "Finish" да се отпечатат четири реда:
            //o "Total tickets: {общият брой закупени билети за всички филми}"
            //o "{процент на студентските билети}% student tickets."
            //o "{процент на стандартните билети}% standard tickets."
            //o "{процент на детските билети}% kids tickets."
            string movieTitle = string.Empty;
            string typeOfTicket = string.Empty;
            int numberOfSeats = 0;
            int numberOfStudents = 0;
            int numberOfStandart = 0;
            int numberOfKids = 0;
            int movieAudienceCounter = 0;
            while (movieTitle != "Finish")
            {       
                movieTitle = Console.ReadLine();
                if (movieTitle != "Finish")
                {
                    numberOfSeats = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= numberOfSeats; i++)
                    {
                        typeOfTicket = Console.ReadLine();
                        switch (typeOfTicket)
                        {
                            case "student":
                                numberOfStudents++;
                                break;
                            case "standard":
                                numberOfStandart++;
                                break;
                            case "kid":
                                numberOfKids++;
                                break;
                        }
                        if (typeOfTicket == "End")
                        {
                            break;
                        }
                        movieAudienceCounter++;
                    }
                }
                else
                {
                    break;
                }
                Console.WriteLine($"{movieTitle} - {((movieAudienceCounter / (double)numberOfSeats) * 100):f2}% full.");
                movieAudienceCounter = 0;
            }
            Console.WriteLine($"Total tickets: {(numberOfKids + numberOfStudents + numberOfStandart)}");
            Console.WriteLine($"{(((double)numberOfStudents / (numberOfKids + numberOfStudents + numberOfStandart)) * 100):f2}% student tickets.");
            Console.WriteLine($"{(((double)numberOfStandart / (numberOfKids + numberOfStudents + numberOfStandart)) * 100):f2}% standard tickets.");
            Console.WriteLine($"{(((double)numberOfKids / (numberOfKids + numberOfStudents + numberOfStandart)) * 100):f2}% kids tickets.");
        }
    }
}
