using System;

namespace _05._Movie_Ratings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Деси много обича да гледа филми, но често й е трудно да си избере подходящ за гледане. Набелязва си определен брой филми и иска
            //да си избере кой филм да гледа спрямо рейтинга на филмите. Напишете програма, която показва кой филм е с най-висок рейтинг,
            //кой е с най-нисък и колко е средният рейтинг от всички филми, които си е набелязала да гледа.
            //Вход
            //От конзолата първо се чете един ред:
            // Брой филми, които си е набелязала Деси – цяло число в интервала[1...20]
            //За всеки филм се прочитат два отделни реда:
            // Име на филма – текст
            // Рейтинг на филма - реално число в интервала[1.00...10.00]
            //Изход
            //Отпечатват се три реда в следния формат:
            // "{име на филма с най-висок рейтинг} is with highest rating: {рейтинг на филма}"
            // "{име на филма с най-нисък рейтинг} is with lowest rating: {рейтинг на филма}"
            // "Average rating: {средният рейтинг на всички филми}"
            //Максималният, минималният и средният рейтинг да се форматира до първата цифра след десетичния знак.
            int numberOfMovies = int.Parse(Console.ReadLine());
            double maxRating = double.MinValue;
            double minRating = double.MaxValue;
            double summary = 0;
            string maxRatingMovie = string.Empty;
            string minRatingMovie = string.Empty;
            for (int i = 1; i <= numberOfMovies; i++)
            {
                string movieTitle = Console.ReadLine();
                double movieRating = double.Parse(Console.ReadLine());
                bool isItMaxRating = movieRating > maxRating;
                bool isItMinRating = movieRating < minRating;
                if (isItMaxRating)
                {
                    maxRating = movieRating;
                    if (maxRating == movieRating)
                    {
                        maxRatingMovie = movieTitle;
                    }
                }
                else if (isItMinRating)
                {
                    minRating = movieRating;
                    if (minRating == movieRating)
                    {
                        minRatingMovie = movieTitle;
                    }
                }
                summary += movieRating;
            }
            Console.WriteLine($"{maxRatingMovie} is with highest rating: {maxRating:f1}");
            Console.WriteLine($"{minRatingMovie} is with lowest rating: {minRating:f1}");
            Console.WriteLine($"Average rating: {(summary / numberOfMovies):f1}");
        }
    }
}
