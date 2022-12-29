using System;

namespace _06._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вашата задача е да напишете програма, която да изчислява процента на билетите за всеки тип от
            //продадените билети: студентски(student), стандартен(standard) и детски(kid), за всички прожекции.
            //Трябва да изчислите и колко процента от залата е запълнена за всяка една прожекция.
            //Вход
            //Входът е поредица от цели числа и текст:
            //•	На първия ред до получаване на командата "Finish" - име на филма – текст
            //•	На втори ред – свободните места в салона за всяка прожекция – цяло число[1 … 100]
            //•	За всеки филм, се чете по един ред до изчерпване на свободните места в залата или до получаване
            //на командата "End":
            //o Типа на закупения билет - текст("student", "standard", "kid")
            //Изход
            //На конзолата трябва да се печатат следните редове:
            //•	След всеки филм да се отпечата, колко процента от кино залата е пълна
            //"{името на филма} - {процент запълненост на залата}% full."
            //•	При получаване на командата "Finish" да се отпечатат четири реда:
            //o   "Total tickets: {общият брой закупени билети за всички филми}"
            //o   "{процент на студентските билети}% student tickets."
            //o   "{процент на стандартните билети}% standard tickets."
            //o   "{процент на детските билети}% kids tickets."
            int totalStudentTickets = 0;
            double totalStandardTickets = 0;
            double totalKidTickets = 0;
            double totalSalesOfTickets = 0;
            string title = Console.ReadLine();
            while (title != "Finish")
            {
                int availableSeats = int.Parse(Console.ReadLine());
                string typeOfTicket = Console.ReadLine();
                int studentTickets = 0;
                int standardTickets = 0;
                int kidTickets = 0;
                int totalSales = 0;
                while (typeOfTicket != "End")
                {
                    switch (typeOfTicket)
                    {
                        case "student":
                            studentTickets++;
                            totalStudentTickets++;
                            totalSalesOfTickets++;
                            break;
                        case "standard":
                            standardTickets++;
                            totalStandardTickets++;
                            totalSalesOfTickets++;
                            break;
                        case "kid":
                            kidTickets++;
                            totalKidTickets++;
                            totalSalesOfTickets++;
                            break;
                    }
                    totalSales = studentTickets + standardTickets + kidTickets;
                    if (totalSales == availableSeats)
                    {
                        break;
                    }
                    else
                    {
                        typeOfTicket = Console.ReadLine();
                    }
                }
                Console.WriteLine($"{title} - {(double)totalSales / availableSeats * 100:f2}% full.");
                title = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {totalSalesOfTickets}");
            Console.WriteLine($"{(totalStudentTickets *100 / totalSalesOfTickets):f2}% student tickets.");
            Console.WriteLine($"{(totalStandardTickets * 100 / totalSalesOfTickets):f2}% standard tickets.");
            Console.WriteLine($"{(totalKidTickets * 100 / totalSalesOfTickets):f2}% kids tickets.");
        }
    }
}
