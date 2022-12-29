using System;

namespace _07.TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            //Катерачи от цяла България се събират на групи и набелязват следващите върхове за изкачване. Според размера на групата,
            //катерачите ще изкачват различни върхове.
            //· Група до 5 човека – изкачват Мусала
            //· Група от 6 до 12 човека – изкачват Монблан
            //· Група от 13 до 25 човека – изкачват Килиманджаро
            //· Група от 26 до 40 човека – изкачват К2
            //· Група от 41 или повече човека – изкачват Еверест
            //Да се напише програма, която изчислява процента на катерачите изкачващи всеки връх.
            //Вход
            //От конзолата се четат поредица от числа, всяко на отделен ред:
            //· На първия ред – броя на групите от катерачи – цяло число в интервала[1...1000]
            //· За всяка една група на отделен ред – броя на хората в групата – цяло число в интервала[1...1000]
            //Изход
            //Да се отпечатат на конзолата 5 реда, всеки от които съдържа процент между 0.00 % и 100.00 % с точност до втората цифра след
            //десетичната запетая.
            //· Първи ред -процентът изкачващи Мусала
            //· Втори ред – процентът изкачващи Монблан
            //· Трети ред – процентът изкачващи Килиманджаро
            //· Четвърти ред – процентът изкачващи К2
            //· Пети ред – процентът изкачващи Еверест
            int numberOfGroups = int.Parse(Console.ReadLine());
            int volunteersForMusala = 0;
            int volunteersForMonblan = 0;
            int volunteersForKilimandjaro = 0;
            int volunteersForK2 = 0;
            int volunteersForEverest = 0;
            int volunteersTotalNumber = 0;
            for (int i = 1; i <= numberOfGroups; i++)
            {
                int membersOfGroup = int.Parse(Console.ReadLine());
                volunteersTotalNumber += membersOfGroup;
                bool areTheyHeadedForMusala = membersOfGroup >= 1 && membersOfGroup <= 5;
                bool areTheyHeadedForMonblan = membersOfGroup >= 6 && membersOfGroup <= 12;
                bool areTheyHeadedForKilimandjaro = membersOfGroup >= 13 && membersOfGroup <= 25;
                bool areTheyHeadedForK2 = membersOfGroup >= 26 && membersOfGroup <= 40;
                bool areTheyHeadedForEverest = membersOfGroup >= 41;
                if (areTheyHeadedForMusala)
                {
                    volunteersForMusala += membersOfGroup;
                }
                else if (areTheyHeadedForMonblan)
                {
                    volunteersForMonblan += membersOfGroup;
                }
                else if (areTheyHeadedForKilimandjaro)
                {
                    volunteersForKilimandjaro += membersOfGroup;
                }
                else if (areTheyHeadedForK2)
                {
                    volunteersForK2 += membersOfGroup;
                }
                else if (areTheyHeadedForEverest)
                {
                    volunteersForEverest += membersOfGroup;
                }
            }
            Console.WriteLine($"{(((double)volunteersForMusala / volunteersTotalNumber) * 100):f2}%");
            Console.WriteLine($"{(((double)volunteersForMonblan / volunteersTotalNumber) * 100):f2}%");
            Console.WriteLine($"{(((double)volunteersForKilimandjaro / volunteersTotalNumber) * 100):f2}%");
            Console.WriteLine($"{(((double)volunteersForK2 / volunteersTotalNumber) * 100):f2}%");
            Console.WriteLine($"{(((double)volunteersForEverest / volunteersTotalNumber) * 100):f2}%");
        }
    }
}
