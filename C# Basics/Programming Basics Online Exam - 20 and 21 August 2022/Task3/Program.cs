using System;

namespace _03CatLife 
{
    class Program
    {
        static void Main(string[] args)
        {
//Средната продължителност на живота на котките зависи от породата, като 6 човешки месеца се равняват на 1 котешки месец. В таблицата са
//дадени различни породи котки и продължителността на живота им спрямо пола.
//Порода        British Shorthair       Siamese     Persian     Ragdoll     American Shorthair      Siberian
//Мъжки пол
//(m)           13 години               15 години   14 години   16 години   12 години               11 години
//Женски пол
//(f)           14 години               16 години   15 години   17 години   13 години               12 години
//Напишете програма, която изчислява колко котешки месеца живее всяка котка. При въвеждане на невалидна порода да се отпечатва:
//{ порода} is invalid cat!
//Вход
//Входът се чете от конзолата и съдържа точно 2 реда:
//•	Порода на котката  –  текст  –  една от възможностите: "British Shorthair", "Siamese", "Persian", "Ragdoll", "American Shorthair" или "Siberian"
//•	Пол на котката  – символ –  'm' или 'f'
//Изход
//Да се отпечата на конзолата:
//"{котешки месецa} cat months"
//Резултатът трябва да е закръглен до най - близкото цяло число надолу.
            string breed = Console.ReadLine();
            char gender = char.Parse(Console.ReadLine());
            int life = 0;
            bool isItValidBreed = true;
            switch (breed)
            {
                case "British Shorthair":
                    switch (gender)
                    {
                        case 'm':
                            life = 13;
                            break;
                        case 'f':
                            life = 14;
                            break;
                    }
                    break;
                case "Siamese":
                    switch (gender)
                    {
                        case 'm':
                            life = 15;
                            break;
                        case 'f':
                            life = 16;
                            break;
                    }
                    break;
                case "Persian":
                    switch (gender)
                    {
                        case 'm':
                            life = 14;
                            break;
                        case 'f':
                            life = 15;
                            break;
                    }
                    break;
                case "Ragdoll":
                    switch (gender)
                    {
                        case 'm':
                            life = 16;
                            break;
                        case 'f':
                            life = 17;
                            break;
                    }
                    break;
                case "American Shorthair":
                    switch (gender)
                    {
                        case 'm':
                            life = 12;
                            break;
                        case 'f':
                            life = 13;
                            break;
                    }
                    break;
                case "Siberian":
                    switch (gender)
                    {
                        case 'm':
                            life = 11;
                            break;
                        case 'f':
                            life = 12;
                            break;
                    }
                    break;
                default:
                    Console.WriteLine($"{breed} is invalid cat!");
                    isItValidBreed = false;
                    break;
            }
            if (isItValidBreed)
            {
                double catMonths = Math.Floor((life * 12.0) / 6);
                Console.WriteLine($"{catMonths} cat months");
            }
        }
    }
}
