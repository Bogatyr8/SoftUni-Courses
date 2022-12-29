using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ани отива до родния си град след много дълъг период извън страната. Прибирайки се вкъщи тя вижда старата библиотека на баба си и
            //си спомня за любимата си книга. Помогнете на Ани, като напишете програма, в която тя въвежда търсената от нея книга(текст). Докато
            //Ани не намери любимата си книга или не провери всички в библиотеката, програмата трябва да чете всеки път на нов ред името на
            //всяка следваща книга(текст). Книгите в библиотеката са свършили щом получите текст "No More Books".
            //•	Ако не открие търсената книгата да се отпечата на два реда:
            //o"The book you search is not here!"
            //o"You checked {брой} books."
            //•	Ако открие книгата си се отпечатва един ред:
            //o"You checked {брой} books and found it."
            int counter = 0;
            string nameOfBookAniLooksFor = Console.ReadLine();
            string nameOfCurrentBook = Console.ReadLine();
            bool didAniFoundTheBook = nameOfCurrentBook != nameOfBookAniLooksFor;
            while (didAniFoundTheBook)
            {
                bool areThereMoreBooks = nameOfCurrentBook == "No More Books";
                if (areThereMoreBooks)
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {counter} books.");
                    break;
                }
                counter++;
                nameOfCurrentBook = Console.ReadLine();
                didAniFoundTheBook = nameOfCurrentBook != nameOfBookAniLooksFor;
            }
            bool didAniNotFoundTheBook = nameOfCurrentBook != "No More Books";
            if (didAniNotFoundTheBook)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
        }
    }
}
