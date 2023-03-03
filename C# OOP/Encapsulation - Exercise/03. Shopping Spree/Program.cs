//Create two classes: 
//Person
//Product
//Each person should have a name, money, and a bag of products. Each product should have a name and a
//cost. The name cannot be an empty string. Money cannot be a negative number. 
//Create a program where each command corresponds to a person buying a product. If the person can
//afford a product, add it to his bag. If a person doesn’t have enough money, print an appropriate
//message ("{personName} can't afford {productName}").
//On the first two lines, you are given all people and all products. After all, purchases print every
//person in the order of appearance and all products that he has bought also in order of appearance.
//If nothing was bought, print the name of the person followed by "Nothing bought". 
//In case of invalid input (negative money Exception message: "Money cannot be negative") or an empty
//name (empty name Exception message: "Name cannot be empty") break the program with an appropriate
//message. See the examples below:

using System;
using System.Collections.Generic;
using ShoppingSpree;


//Dictionary<string, decimal> people = new();

//Dictionary<string, decimal> products = new();

List<Person> people = new();
List<Product> products = new();

try
{
    Inittialize(people, products);
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
    return;
}

string inputArg;
while ((inputArg = Console.ReadLine()) != "END")
{
    string[] input = inputArg
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string personName = input[0];
    string productTitle = input[1];
    Person person = GetPerson(people, personName);
    Product product = GetProduct(products, productTitle);
    if (person.Money >= product.Price)
    {
        person.Money -= product.Price;
        person.AddToList(product);
    }
    else
    {
        Console.WriteLine($"{person.Name} can't afford {product.Name}");
    }
}

foreach (Person person in people)
{
    Console.WriteLine(person);
}


static Product GetProduct(List<Product> products, string productTitle)
{
    foreach (Product p in products)
    {
        if (p.Name == productTitle)
        {

            return p;
        }
    }
    return null;
}
static Person GetPerson(List<Person> people, string personName)
{
    foreach (Person p in people)
    {
        if (p.Name == personName)
        {

            return p;
        }
    }
    return null;
}
static void Inittialize(List<Person> people, List<Product> products)
{
    string[] peopleList = Console.ReadLine()
        .Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);

    string[] productsList = Console.ReadLine()
        .Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);

    for (int i = 0; i < peopleList.Length; i += 2)
    {
        string name = peopleList[i];
        decimal money = decimal.Parse(peopleList[i + 1]);
        Person person = new(name, money);
        people.Add(person);
    }

    for (int i = 0; i < productsList.Length; i += 2)
    {
        string productName = productsList[i];
        decimal price = decimal.Parse(productsList[i + 1]);
        Product product = new(productName, price);
        products.Add(product);
    }
}