//NOTE: You need a public StartUp class with the namespace CustomRandomList.
//Create a RandomList class that has all the functionality of List<string>.
//Add an additional function that returns and removes a random element from
//the list.
//Public method: RandomString(): string
using System;
using System.Collections.Generic;

namespace CustomRandomList;

public class StartUp
{
    static void Main(string[] args)
    {
        
        RandomList list = new RandomList();
        list.Add("Boyan");
        list.Add("Chara");
        list.Add("Zori");
        list.Add("Penka");
        list.Add("Marti");
        list.Add("Mitko");
        list.Add("Cveti");
        list.Add("Vanya");
        list.Add("Stefka");
        Console.WriteLine(list.RandomString());
    }
}