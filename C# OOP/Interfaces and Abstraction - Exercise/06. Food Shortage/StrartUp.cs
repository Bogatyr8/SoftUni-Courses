//Your totalitarian dystopian society suffers a shortage of food, so many
//rebels appear. Extend the code from your previous task with new
//functionality to solve this task.
//Define a class Rebel which has a name, age, and group (string), names
//are unique - there will never be 2 Rebels/Citizens or a Rebel and 
//Citizen with the same name. Define an interface IBuyer which defines
//a method BuyFood() and an integer property Food. Implement the IBuyer
// interface in the Citizen and Rebel class, both Rebels and Citizens 
// start with 0 food, when a Rebel buys food his Food increases by 5,
// when a Citizen buys food his Food increases by 10.
//On the first line of the input you will receive an integer N - the
//number of people, on each of the next N lines you will receive
//information in one of the following formats
//"<name> <age> <id> <birthdate>" for a Citizen or "<name> <age><group>"
//for a Rebel. After the N lines, until the command "End" is received,
//you will receive names of people who bought food, each on a new line.
//Note that not all names may be valid, in case of an incorrect name -
//nothing should happen.
//Output
//The output consists of only one line on which you should print the
//total amount of food purchased.

using System;
using System.Collections.Generic;
using System.Linq;
using FoodShortage;

List<Person> buyers = new List<Person>();

Initiallize(buyers);

string inputArg;
while ((inputArg = Console.ReadLine()) != "End")
{
    Person person = null;
    string[] input = inputArg.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    string name = input[0];
    person = buyers.FirstOrDefault(x => x.Name == name);
    if (person != null)
    {
        person.BuyFood();
    }
}

Console.WriteLine(buyers.Sum(p => p.Food));

static void Initiallize(List<Person> buyers)
{
    int n = int.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++)
    {
        string[] newPerson = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (newPerson.Length == 4)
        {
            Person buyerCitizen = new Citizen(newPerson[0], int.Parse(newPerson[1]), newPerson[2], newPerson[3]);
            buyers.Add(buyerCitizen);
        }
        else if (newPerson.Length == 3)
        {
            Person buyerRebel = new Rebel(newPerson[0], int.Parse(newPerson[1]), newPerson[2]);
            buyers.Add(buyerRebel);
        }
    }
}

