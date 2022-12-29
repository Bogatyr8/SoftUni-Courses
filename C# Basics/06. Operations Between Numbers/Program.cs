using System;

namespace _06._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете две цели числа(N1 и N2) и оператор, с който да се извърши дадена математическа операция с тях.
            //Възможните операции са: Събиране(+), Изваждане(-), Умножение(*), Деление(/) и Модулно деление(%).При събиране, изваждане и
            //умножение на конзолата трябва да се отпечатат резултата и дали той е четен или нечетен.При обикновеното деление – резултата.
            //При модулното деление – остатъка.Трябва да се има предвид, че делителят може да е равен на 0(нула), а на нула не се дели. В
            //този случай трябва да се отпечата специално съобщениe.
            //Вход
            //От конзолата се прочитат 3 реда, въведени от потребителя:
            //· N1 – цяло число в интервала[0...40 000]
            //· N2 – цяло число в интервала[0...40 000]
            //· Оператор – един символ измежду: „+“, „-“, „*“, „/“, „%“
            //Изход
            //Да се отпечата на конзолата един ред:
            //· Ако операцията е деление:
            //o "{N1} / {N2} = {резултат}" – резултатът е форматиран до вторият знак след дес.запетая
            //· Ако операцията е модулно деление:
            //o "{N1} % {N2} = {остатък}"
            //· В случай на деление с 0(нула)
            //o "Cannot divide {N1} by zero"
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            int result = 0;
            double devisionResult = 0;
            switch (operation)
            {
                case "+":
                    result = n1 + n2;
                    if (result % 2 ==0)
                    {
                        Console.WriteLine($"{n1} + {n2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} + {n2} = {result} - odd");
                    }
                    break;
                case "-":
                    result = n1 - n2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{n1} - {n2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} - {n2} = {result} - odd");
                    }
                    break;
                case "*":
                    result = n1 * n2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{n1} * {n2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} * {n2} = {result} - odd");
                    }
                    break;
                case "/":
                    if (n2 != 0)
                    {
                        double divN1 = n1;
                        double divN2 = n2;
                        devisionResult = divN1 / divN2;
                        Console.WriteLine($"{n1} / {n2} = {devisionResult:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    break;
                case "%":
                    if (n2 != 0)
                    {
                        devisionResult = n1 % n2;
                        Console.WriteLine($"{n1} % {n2} = {devisionResult}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    break;
            }
        }
    }
}
