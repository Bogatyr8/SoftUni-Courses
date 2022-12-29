using System;

namespace _04._Cinema_Voucher
{
    class Program
    {
        static void Main(string[] args)
        {
            //Любо е голям почитател на киното и редовно ходи на прожекции и участва в томболи, от които често печели
            //ваучери за кино. Вашата задача е да напишете програма, която да изчислява колко покупки от киното може
            //да си купи Любо със спечеленият ваучер. Ако името на покупката съдържа повече от 8 символа, то тя е билет
            //за филм, а нейната цена представлява сумата на ASCII символите от първите ѝ два символа. Ако името на
            //покупката съдържа 8 или по-малко символа, нейната цена е равна на стойността на първия ASCII символ в
            //името.Любо въвежда името на покупките, които желае, докато не въведе "End" или не въведе покупка,
            //чиято стойност е по - голяма от останалата сума на ваучера.
            //Вход
            //Първоначално се чете един ред:
            // Стойността на ваучера – цяло число в интервала[1...100000]
            //След това до получаване на команда "End" или до изчерпването на ваучера, се чете по един ред:
            //o Покупката, която Любо е избрал – текст
            //Изход
            //Програмата приключва при въвеждане на команда "End" или при покупка чиято стойност е по - голяма от
            //останалите пари от ваучера.На конзолата трябва да се напечатат три реда:
            // "{брои закупени билети}"
            // "{брой закупени други покупки}"
            int vaucherValue = int.Parse(Console.ReadLine());
            string input = string.Empty;
            int movieTicketCount = 0;
            int otherArticlesCount = 0;
            int char1 = 0;
            int char2 = 0;
            do
            {
                input = Console.ReadLine();
                int lengthOfText = input.Length;
                char1 = input[0];
                char2 = input[1];
                if (lengthOfText > 8) //is it a movie?
                {
                    vaucherValue -= char1 + char2;
                    if (vaucherValue >= 0)
                    {
                        movieTicketCount++;
                    }

                }
                else if (lengthOfText <= 8 && input != "End") // is it an article?
                {
                    vaucherValue -= char1;
                    if (vaucherValue >= 0)
                    {
                        otherArticlesCount++;
                    }
                }
            }
            while (vaucherValue > 0 && input != "End");
            Console.WriteLine(movieTicketCount);
            Console.WriteLine(otherArticlesCount);
        }
    }
}
