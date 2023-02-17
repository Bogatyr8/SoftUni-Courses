//Create a Class Threeuple. Its name is telling us that it will hold no longer, just a pair of
//objects. The task is simple, our Threeuple should hold three objects. Make it have getters and
//setters. You can even extend the previous class.
//Input
//The input consists of three lines:
//The first one is holding a name, an address and a town. Format of the input:
//{first name} {last name} {address} {town}
//The second line is holding a name, beer liters, and a boolean variable with value - drunk or
//not. Format:
//{name} {liters of beer} {drunk or not}
//The last line will hold a name, a bank balance (double) and a bank name. Format:
//{name} {account balance} {bank name}
//Output
//Print the Threeuples' objects in format:
//"{firstElement} -> {secondElement} -> {thirdElement}"

using System;
using ThreeupleType;

string[] personTokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

string[] drinkTokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

string[] bankAccountTokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

Threeuple<string, string, string> nameAddress =
    new($"{personTokens[0]} {personTokens[1]}", personTokens[2], string.Join(" ", personTokens[3..]));

Threeuple<string, int, bool> nameBeer =
    new(drinkTokens[0], int.Parse(drinkTokens[1]), drinkTokens[2] == "drunk");

Threeuple<string , double, string> bankAccount =
    new(bankAccountTokens[0], double.Parse(bankAccountTokens[1]), bankAccountTokens[2]);

Console.WriteLine(nameAddress);
Console.WriteLine(nameBeer);
Console.WriteLine(bankAccount);