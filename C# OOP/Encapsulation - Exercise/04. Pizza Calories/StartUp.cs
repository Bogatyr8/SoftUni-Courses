using System;
using PizzaCalories.Models;

try
{
    string[] pizzaTokens = Console.ReadLine()
        .Split(" ");
    string[] doughTokens = Console.ReadLine()
        .Split(" ");

    string pizzaName = pizzaTokens[1];
    string doughType = doughTokens[1];
    string bakingType = doughTokens[2];
    double doughWeight = double.Parse(doughTokens[3]);

    Dough dough = new(doughType, bakingType, doughWeight);
    Pizza pizza = new(pizzaName, dough);

    string toppingInput;
    while ((toppingInput = Console.ReadLine()) != "END")
    {
        string[] toppingTokens = toppingInput
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);
        string toppingType = toppingTokens[1];
        double toppingWeight = double.Parse(toppingTokens[2]);
        Topping topping = new(toppingType, toppingWeight);
        pizza.AddTopping(topping);
    }
    Console.WriteLine(pizza);
}
catch (ArgumentException ex)
{

    Console.WriteLine(ex.Message);
}